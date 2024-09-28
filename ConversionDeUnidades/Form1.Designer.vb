<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        btnCerrar = New Button()
        Label2 = New Label()
        PictureLongitud = New PictureBox()
        PictureTiempo = New PictureBox()
        PictureAlmacenamiento = New PictureBox()
        PictureMasa = New PictureBox()
        CType(PictureLongitud, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureTiempo, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureAlmacenamiento, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureMasa, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCerrar
        ' 
        btnCerrar.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCerrar.Location = New Point(670, 366)
        btnCerrar.Name = "btnCerrar"
        btnCerrar.Size = New Size(97, 47)
        btnCerrar.TabIndex = 0
        btnCerrar.Text = "Cerrar"
        btnCerrar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(129, 26)
        Label2.Name = "Label2"
        Label2.Size = New Size(484, 49)
        Label2.TabIndex = 5
        Label2.Text = "Conversor de unidades"
        ' 
        ' PictureLongitud
        ' 
        PictureLongitud.Image = CType(resources.GetObject("PictureLongitud.Image"), Image)
        PictureLongitud.Location = New Point(95, 102)
        PictureLongitud.Name = "PictureLongitud"
        PictureLongitud.Size = New Size(242, 151)
        PictureLongitud.SizeMode = PictureBoxSizeMode.StretchImage
        PictureLongitud.TabIndex = 6
        PictureLongitud.TabStop = False
        ' 
        ' PictureTiempo
        ' 
        PictureTiempo.Image = CType(resources.GetObject("PictureTiempo.Image"), Image)
        PictureTiempo.Location = New Point(380, 102)
        PictureTiempo.Name = "PictureTiempo"
        PictureTiempo.Size = New Size(242, 151)
        PictureTiempo.SizeMode = PictureBoxSizeMode.StretchImage
        PictureTiempo.TabIndex = 7
        PictureTiempo.TabStop = False
        ' 
        ' PictureAlmacenamiento
        ' 
        PictureAlmacenamiento.Image = CType(resources.GetObject("PictureAlmacenamiento.Image"), Image)
        PictureAlmacenamiento.Location = New Point(95, 262)
        PictureAlmacenamiento.Name = "PictureAlmacenamiento"
        PictureAlmacenamiento.Size = New Size(242, 151)
        PictureAlmacenamiento.SizeMode = PictureBoxSizeMode.StretchImage
        PictureAlmacenamiento.TabIndex = 8
        PictureAlmacenamiento.TabStop = False
        ' 
        ' PictureMasa
        ' 
        PictureMasa.Image = CType(resources.GetObject("PictureMasa.Image"), Image)
        PictureMasa.Location = New Point(380, 262)
        PictureMasa.Name = "PictureMasa"
        PictureMasa.Size = New Size(242, 151)
        PictureMasa.SizeMode = PictureBoxSizeMode.StretchImage
        PictureMasa.TabIndex = 9
        PictureMasa.TabStop = False
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PictureMasa)
        Controls.Add(PictureAlmacenamiento)
        Controls.Add(PictureTiempo)
        Controls.Add(PictureLongitud)
        Controls.Add(Label2)
        Controls.Add(btnCerrar)
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "INICIO"
        CType(PictureLongitud, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureTiempo, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureAlmacenamiento, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureMasa, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnCerrar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureLongitud As PictureBox
    Friend WithEvents PictureTiempo As PictureBox
    Friend WithEvents PictureAlmacenamiento As PictureBox
    Friend WithEvents PictureMasa As PictureBox

End Class
