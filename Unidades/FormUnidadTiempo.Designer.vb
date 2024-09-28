<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUnidadTiempo
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label5 = New Label()
        Label4 = New Label()
        Label3 = New Label()
        TextResultado = New TextBox()
        TextNumero = New TextBox()
        Label2 = New Label()
        Label1 = New Label()
        ComboUnidadEquivalencia = New ComboBox()
        ComboUnidadBase = New ComboBox()
        btnSalir = New Button()
        btnCalcular = New Button()
        SuspendLayout()
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Cascadia Mono", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(382, 129)
        Label5.Name = "Label5"
        Label5.Size = New Size(171, 20)
        Label5.TabIndex = 21
        Label5.Text = "Unidad equivalente"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Cascadia Mono", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(67, 129)
        Label4.Name = "Label4"
        Label4.Size = New Size(108, 20)
        Label4.TabIndex = 20
        Label4.Text = "Unidad base"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Cascadia Mono", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(382, 259)
        Label3.Name = "Label3"
        Label3.Size = New Size(90, 20)
        Label3.TabIndex = 19
        Label3.Text = "Resultado"
        ' 
        ' TextResultado
        ' 
        TextResultado.Location = New Point(488, 256)
        TextResultado.Multiline = True
        TextResultado.Name = "TextResultado"
        TextResultado.Size = New Size(246, 37)
        TextResultado.TabIndex = 18
        ' 
        ' TextNumero
        ' 
        TextNumero.Location = New Point(145, 256)
        TextNumero.Multiline = True
        TextNumero.Name = "TextNumero"
        TextNumero.Size = New Size(169, 37)
        TextNumero.TabIndex = 17
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Cascadia Mono", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(67, 259)
        Label2.Name = "Label2"
        Label2.Size = New Size(63, 20)
        Label2.TabIndex = 16
        Label2.Text = "Número"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Cascadia Mono", 22.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(131, 27)
        Label1.Name = "Label1"
        Label1.Size = New Size(462, 49)
        Label1.TabIndex = 15
        Label1.Text = "Conversión de tiempo"
        ' 
        ' ComboUnidadEquivalencia
        ' 
        ComboUnidadEquivalencia.DropDownStyle = ComboBoxStyle.DropDownList
        ComboUnidadEquivalencia.FormattingEnabled = True
        ComboUnidadEquivalencia.Items.AddRange(New Object() {"Milímetro", "Centimetro", "Pulgada", "Pie", "Yarda", "Metro", "Kilometro"})
        ComboUnidadEquivalencia.Location = New Point(382, 161)
        ComboUnidadEquivalencia.Name = "ComboUnidadEquivalencia"
        ComboUnidadEquivalencia.Size = New Size(352, 28)
        ComboUnidadEquivalencia.TabIndex = 14
        ' 
        ' ComboUnidadBase
        ' 
        ComboUnidadBase.DropDownStyle = ComboBoxStyle.DropDownList
        ComboUnidadBase.FormattingEnabled = True
        ComboUnidadBase.Items.AddRange(New Object() {"Milímetro", "Centimetro", "Pulgada", "Pie", "Yarda", "Metro", "Kilometro"})
        ComboUnidadBase.Location = New Point(67, 161)
        ComboUnidadBase.Name = "ComboUnidadBase"
        ComboUnidadBase.Size = New Size(288, 28)
        ComboUnidadBase.TabIndex = 13
        ' 
        ' btnSalir
        ' 
        btnSalir.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSalir.Location = New Point(471, 384)
        btnSalir.Name = "btnSalir"
        btnSalir.Size = New Size(138, 40)
        btnSalir.TabIndex = 12
        btnSalir.Text = "Salir"
        btnSalir.UseVisualStyleBackColor = True
        ' 
        ' btnCalcular
        ' 
        btnCalcular.Font = New Font("Cascadia Mono", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnCalcular.Location = New Point(226, 384)
        btnCalcular.Name = "btnCalcular"
        btnCalcular.Size = New Size(129, 40)
        btnCalcular.TabIndex = 11
        btnCalcular.Text = "Calcular"
        btnCalcular.UseVisualStyleBackColor = True
        ' 
        ' FormUnidadTiempo
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(TextResultado)
        Controls.Add(TextNumero)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(ComboUnidadEquivalencia)
        Controls.Add(ComboUnidadBase)
        Controls.Add(btnSalir)
        Controls.Add(btnCalcular)
        Name = "FormUnidadTiempo"
        Text = "TIEMPO"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextResultado As TextBox
    Friend WithEvents TextNumero As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ComboUnidadEquivalencia As ComboBox
    Friend WithEvents ComboUnidadBase As ComboBox
    Friend WithEvents btnSalir As Button
    Friend WithEvents btnCalcular As Button
End Class
