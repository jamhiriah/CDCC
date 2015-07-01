Imports System.Runtime.InteropServices
Imports System.Reflection
Imports System.Drawing
Imports System.Threading

Module Keyboard

    Public Declare Function UnhookWindowsHookEx Lib "user32" _
       (ByVal hHook As Integer) As Integer

    Public Declare Function SetWindowsHookEx Lib "user32" _
      Alias "SetWindowsHookExA" (ByVal idHook As Integer, _
      ByVal lpfn As KeyboardHookDelegate, ByVal hmod As Integer, _
      ByVal dwThreadId As Integer) As Integer

    Private Declare Function GetAsyncKeyState Lib "user32" _
      (ByVal vKey As Integer) As Integer

    Private Declare Function CallNextHookEx Lib "user32" _
      (ByVal hHook As Integer, _
      ByVal nCode As Integer, _
      ByVal wParam As Integer, _
      ByVal lParam As KBDLLHOOKSTRUCT) As Integer

    Public Structure KBDLLHOOKSTRUCT
        Public vkCode As Integer
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public dwExtraInfo As Integer
    End Structure

    ' Low-Level Keyboard Constants
    Private Const HC_ACTION As Integer = 0
    Private Const LLKHF_EXTENDED As Integer = &H1
    Private Const LLKHF_INJECTED As Integer = &H10
    Private Const LLKHF_ALTDOWN As Integer = &H20
    Private Const LLKHF_UP As Integer = &H80

    ' Virtual Keys
    Public Const VK_TAB = &H9
    Public Const VK_CONTROL = &H11
    Public Const VK_ESCAPE = &H1B
    Public Const VK_DELETE = &H2E
    Public Const VK_LWIN = &H5B  'Left Windows key (Microsoft® Natural® keyboard)
    Public Const VK_RWIN = &H5C  'Right Windows key (Natural keyboard)
    Public Const VK_APPS = &H5D  'Applications key (Natural keyboard)
    Public Const VK_F4 = 115 'block F4 key


    Private Const WH_KEYBOARD_LL As Integer = 13&


    '-try
    'Private Const vbKeyLWin As Integer = 91
    'Private Const vbKeyRWin As Integer = 92
    'Private Const vbKeyLCtrl As Integer = 162
    'Private Const vbKeyRCtrl As Integer = 163

    'Private Declare Function MessageBeep Lib "user32" (ByVal wType As Long) As Long
    'Private Declare Function GetKeyState Lib "user32" (ByVal nVirtKey As Long) As Integer

    'Private WithEvents apiLink As EventVB.APIFunctions
    'Private WithEvents hook As EventVB.ApiSystemHook
    ''end try

    Public KeyboardHandle As Integer

    ' Implement this function to block as many
    ' key combinations as you'd like
    Public Function IsHooked( _
      ByRef Hookstruct As KBDLLHOOKSTRUCT) As Boolean

        Debug.WriteLine("Hookstruct.vkCode: " & Hookstruct.vkCode)
        Debug.WriteLine(Hookstruct.vkCode = VK_ESCAPE)
        Debug.WriteLine(Hookstruct.vkCode = VK_TAB)

        If Hookstruct.vkCode = VK_LWIN Or Hookstruct.vkCode = VK_RWIN Or Hookstruct.vkCode = VK_APPS Then
            Call HookedState("Windows Key blocked")
            Return True
        End If



        If (Hookstruct.vkCode = VK_ESCAPE) And _
          CBool(GetAsyncKeyState(VK_CONTROL) _
          And &H8000) Then

            Call HookedState("Ctrl + Esc blocked")
            Return True
        End If

        If (Hookstruct.vkCode = VK_TAB) And _
          CBool(Hookstruct.flags And _
          LLKHF_ALTDOWN) Then

            Call HookedState("Alt + Tab blocked")
            Return True
        End If


        '//< v.1.0.7 - 20130925_19:18 >----------------------------------------------------------
        If (Hookstruct.vkCode = VK_TAB) And CBool(Hookstruct.flags And LLKHF_ALTDOWN) And _
            CBool(GetAsyncKeyState(VK_CONTROL) And &H8000) Then

            Call HookedState("Ctrl + Alt + Delete blocked")
            Return True
        End If

        If (Hookstruct.vkCode = VK_TAB) And CBool(GetAsyncKeyState(VK_CONTROL) And &H8000) Then

            Call HookedState("Ctrl + Tab blocked")
            Return True
        End If

        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.AltKeyDown And Hookstruct.vkCode = VK_TAB Then

            Call HookedState("Alt + Tab + Ctrl blocked")
            Return True
        End If

        If My.Computer.Keyboard.AltKeyDown And Hookstruct.vkCode = VK_F4 Then

            Call HookedState("Alt + F4 blocked")
            Return True
        End If

        If My.Computer.Keyboard.CtrlKeyDown And My.Computer.Keyboard.AltKeyDown Then

            Call HookedState("Ctrl + Alt blocked")
            Return True
        End If
        '//</new Attempt >-----------------------------------------------

        If (Hookstruct.vkCode = VK_ESCAPE) And _
          CBool(Hookstruct.flags And _
            LLKHF_ALTDOWN) Then

            Call HookedState("Alt + Escape blocked")
            Return True
        End If

        Return False
    End Function

    Private Sub HookedState(ByVal Text As String)
        ' Debug.WriteLine(Text)
        'frmMain.txtIC.AppendText(Text)

    End Sub

    Public Function KeyboardCallback(ByVal Code As Integer, _
      ByVal wParam As Integer, _
      ByRef lParam As KBDLLHOOKSTRUCT) As Integer

        If (Code = HC_ACTION) Then
            Debug.WriteLine("Calling IsHooked")

            If (IsHooked(lParam)) Then
                Return 1
            End If

        End If

        Return CallNextHookEx(KeyboardHandle, _
          Code, wParam, lParam)

    End Function


    Public Delegate Function KeyboardHookDelegate( _
      ByVal Code As Integer, _
      ByVal wParam As Integer, ByRef lParam As KBDLLHOOKSTRUCT) _
                   As Integer

    <MarshalAs(UnmanagedType.FunctionPtr)> _
    Private callback As KeyboardHookDelegate

    Public Sub HookKeyboard()
        callback = New KeyboardHookDelegate(AddressOf KeyboardCallback)

        KeyboardHandle = SetWindowsHookEx( _
          WH_KEYBOARD_LL, callback, _
          Marshal.GetHINSTANCE( _
          [Assembly].GetExecutingAssembly.GetModules()(0)).ToInt32, 0)

        Call CheckHooked()
    End Sub

    Public Sub CheckHooked()
        If (Hooked()) Then
            Debug.WriteLine("Keyboard hooked")
        Else
            Debug.WriteLine("Keyboard hook failed: " & Err.LastDllError)
        End If
    End Sub

    Private Function Hooked()
        Hooked = KeyboardHandle <> 0
    End Function

    Public Sub UnhookKeyboard()
        If (Hooked()) Then
            Call UnhookWindowsHookEx(KeyboardHandle)
        End If
    End Sub

    'Private Sub hook_KeyDown(ByVal VKey As Long, ByVal scanCode _
    ' As Long, ByVal ExtendedKey As Boolean, ByVal AltDown As _
    ' Boolean, ByVal Injected As Boolean, ByVal Cancel As Boolean)


    '    'Alt Tab
    '    If AltDown And VKey = VK_TAB Then
    '        Cancel = True

    '        'Alt Esc
    '    ElseIf AltDown And VKey = VK_ESCAPE Then
    '        Cancel = True

    '        'Ctrl Esc
    '    ElseIf VKey = VK_ESCAPE Then
    '        'Check if a ctrl key down
    '        If GetKeyState(vbKeyLCtrl) And &HF0000000 Or _
    '            GetKeyState(vbKeyRCtrl) And &HF0000000 Then
    '            Cancel = True
    '        End If

    '        'Windows key (L/R). Used to "disable" the start menu.  
    '        'Stops single keydown of a windows key
    '    ElseIf VKey = vbKeyLWin Or VKey = vbKeyRWin Then
    '        Cancel = True

    '        'Windows + Any
    '        'If there is a hotkey combination being pressed,
    '        'the Windows key will not be stored in VKey,
    '        'So I check the state of the windows keys.  
    '        'If they are down, cancel keys
    '    Else
    '        If GetKeyState(vbKeyLWin) And &HF0000000 Or _
    '            GetKeyState(vbKeyRWin) And &HF0000000 Then
    '            Cancel = True
    '        End If
    '    End If

    '    'This is totally optional of course
    '    If Cancel = True Then 'We have stopped some keystrokes. Beep
    '        MessageBeep(0)
    '    End If

    'End Sub
End Module
