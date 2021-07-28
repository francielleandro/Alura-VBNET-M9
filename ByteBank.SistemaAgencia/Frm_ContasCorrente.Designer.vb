<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ContasCorrente
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ContasCorrente))
        Me.Lbl_ContaCorrente = New System.Windows.Forms.Label()
        Me.Txt_Nome = New System.Windows.Forms.TextBox()
        Me.Txt_Conta = New System.Windows.Forms.TextBox()
        Me.Txt_Agencia = New System.Windows.Forms.TextBox()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SalvarToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Lbl_ContaCorrente
        '
        Me.Lbl_ContaCorrente.AutoSize = True
        Me.Lbl_ContaCorrente.Location = New System.Drawing.Point(9, 25)
        Me.Lbl_ContaCorrente.Name = "Lbl_ContaCorrente"
        Me.Lbl_ContaCorrente.Size = New System.Drawing.Size(39, 13)
        Me.Lbl_ContaCorrente.TabIndex = 0
        Me.Lbl_ContaCorrente.Text = "Label1"
        '
        'Txt_Nome
        '
        Me.Txt_Nome.Location = New System.Drawing.Point(12, 41)
        Me.Txt_Nome.Name = "Txt_Nome"
        Me.Txt_Nome.Size = New System.Drawing.Size(248, 20)
        Me.Txt_Nome.TabIndex = 1
        '
        'Txt_Conta
        '
        Me.Txt_Conta.Location = New System.Drawing.Point(12, 67)
        Me.Txt_Conta.Name = "Txt_Conta"
        Me.Txt_Conta.Size = New System.Drawing.Size(248, 20)
        Me.Txt_Conta.TabIndex = 2
        '
        'Txt_Agencia
        '
        Me.Txt_Agencia.Location = New System.Drawing.Point(11, 94)
        Me.Txt_Agencia.Name = "Txt_Agencia"
        Me.Txt_Agencia.Size = New System.Drawing.Size(249, 20)
        Me.Txt_Agencia.TabIndex = 3
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SalvarToolStripButton})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(271, 25)
        Me.ToolStrip1.TabIndex = 4
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SalvarToolStripButton
        '
        Me.SalvarToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalvarToolStripButton.Image = CType(resources.GetObject("SalvarToolStripButton.Image"), System.Drawing.Image)
        Me.SalvarToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalvarToolStripButton.Name = "SalvarToolStripButton"
        Me.SalvarToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.SalvarToolStripButton.Text = "&Salvar"
        '
        'Frm_ContasCorrente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(271, 277)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.Txt_Agencia)
        Me.Controls.Add(Me.Txt_Conta)
        Me.Controls.Add(Me.Txt_Nome)
        Me.Controls.Add(Me.Lbl_ContaCorrente)
        Me.Name = "Frm_ContasCorrente"
        Me.Text = "Frm_ContasCorrente"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Lbl_ContaCorrente As Label
    Friend WithEvents Txt_Nome As TextBox
    Friend WithEvents Txt_Conta As TextBox
    Friend WithEvents Txt_Agencia As TextBox
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SalvarToolStripButton As ToolStripButton
End Class
