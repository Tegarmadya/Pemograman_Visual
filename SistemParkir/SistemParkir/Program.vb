Imports System
Imports System.Windows.Forms

Namespace SistemParkir
    Module Program
        ''' <summary>
        ''' Titik masuk utama aplikasi.
        ''' </summary>
        <STAThread>
        Sub Main()
            Application.SetHighDpiMode(HighDpiMode.SystemAware)
            Application.EnableVisualStyles()
            Application.SetCompatibleTextRenderingDefault(False)
            Application.Run(New Form1())
        End Sub
    End Module
End Namespace
