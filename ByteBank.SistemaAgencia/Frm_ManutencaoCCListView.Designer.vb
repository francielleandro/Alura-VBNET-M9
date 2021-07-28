<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Frm_ManutencaoCCListView
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Frm_ManutencaoCCListView))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NovoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.Grp_Lista = New System.Windows.Forms.GroupBox()
        Me.Grp_CriterioOrdenacao = New System.Windows.Forms.GroupBox()
        Me.Lvw_Contas = New System.Windows.Forms.ListView()
        Me.Rb_Saldo = New System.Windows.Forms.RadioButton()
        Me.Rb_Nome = New System.Windows.Forms.RadioButton()
        Me.Rb_Conta = New System.Windows.Forms.RadioButton()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStrip1.SuspendLayout()
        Me.Grp_Lista.SuspendLayout()
        Me.Grp_CriterioOrdenacao.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NovoToolStripButton, Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NovoToolStripButton
        '
        Me.NovoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NovoToolStripButton.Image = CType(resources.GetObject("NovoToolStripButton.Image"), System.Drawing.Image)
        Me.NovoToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NovoToolStripButton.Name = "NovoToolStripButton"
        Me.NovoToolStripButton.Size = New System.Drawing.Size(23, 22)
        Me.NovoToolStripButton.Text = "&Novo"
        '
        'Grp_Lista
        '
        Me.Grp_Lista.Controls.Add(Me.Lvw_Contas)
        Me.Grp_Lista.Location = New System.Drawing.Point(13, 45)
        Me.Grp_Lista.Name = "Grp_Lista"
        Me.Grp_Lista.Size = New System.Drawing.Size(200, 100)
        Me.Grp_Lista.TabIndex = 1
        Me.Grp_Lista.TabStop = False
        Me.Grp_Lista.Text = "GroupBox1"
        '
        'Grp_CriterioOrdenacao
        '
        Me.Grp_CriterioOrdenacao.Controls.Add(Me.Rb_Conta)
        Me.Grp_CriterioOrdenacao.Controls.Add(Me.Rb_Nome)
        Me.Grp_CriterioOrdenacao.Controls.Add(Me.Rb_Saldo)
        Me.Grp_CriterioOrdenacao.Location = New System.Drawing.Point(13, 151)
        Me.Grp_CriterioOrdenacao.Name = "Grp_CriterioOrdenacao"
        Me.Grp_CriterioOrdenacao.Size = New System.Drawing.Size(200, 100)
        Me.Grp_CriterioOrdenacao.TabIndex = 2
        Me.Grp_CriterioOrdenacao.TabStop = False
        Me.Grp_CriterioOrdenacao.Text = "GroupBox2"
        '
        'Lvw_Contas
        '
        Me.Lvw_Contas.HideSelection = False
        Me.Lvw_Contas.Location = New System.Drawing.Point(7, 20)
        Me.Lvw_Contas.Name = "Lvw_Contas"
        Me.Lvw_Contas.Size = New System.Drawing.Size(126, 74)
        Me.Lvw_Contas.TabIndex = 0
        Me.Lvw_Contas.UseCompatibleStateImageBehavior = False
        '
        'Rb_Saldo
        '
        Me.Rb_Saldo.AutoSize = True
        Me.Rb_Saldo.Location = New System.Drawing.Point(16, 20)
        Me.Rb_Saldo.Name = "Rb_Saldo"
        Me.Rb_Saldo.Size = New System.Drawing.Size(90, 17)
        Me.Rb_Saldo.TabIndex = 0
        Me.Rb_Saldo.TabStop = True
        Me.Rb_Saldo.Text = "RadioButton1"
        Me.Rb_Saldo.UseVisualStyleBackColor = True
        '
        'Rb_Nome
        '
        Me.Rb_Nome.AutoSize = True
        Me.Rb_Nome.Location = New System.Drawing.Point(16, 43)
        Me.Rb_Nome.Name = "Rb_Nome"
        Me.Rb_Nome.Size = New System.Drawing.Size(90, 17)
        Me.Rb_Nome.TabIndex = 1
        Me.Rb_Nome.TabStop = True
        Me.Rb_Nome.Text = "RadioButton2"
        Me.Rb_Nome.UseVisualStyleBackColor = True
        '
        'Rb_Conta
        '
        Me.Rb_Conta.AutoSize = True
        Me.Rb_Conta.Location = New System.Drawing.Point(16, 65)
        Me.Rb_Conta.Name = "Rb_Conta"
        Me.Rb_Conta.Size = New System.Drawing.Size(90, 17)
        Me.Rb_Conta.TabIndex = 2
        Me.Rb_Conta.TabStop = True
        Me.Rb_Conta.Text = "RadioButton3"
        Me.Rb_Conta.UseVisualStyleBackColor = True
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'Frm_ManutencaoCCListView
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Grp_CriterioOrdenacao)
        Me.Controls.Add(Me.Grp_Lista)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Name = "Frm_ManutencaoCCListView"
        Me.Text = "Frm_ManutencaoCCListView"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.Grp_Lista.ResumeLayout(False)
        Me.Grp_CriterioOrdenacao.ResumeLayout(False)
        Me.Grp_CriterioOrdenacao.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents NovoToolStripButton As ToolStripButton
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents Grp_Lista As GroupBox
    Friend WithEvents Lvw_Contas As ListView
    Friend WithEvents Grp_CriterioOrdenacao As GroupBox
    Friend WithEvents Rb_Conta As RadioButton
    Friend WithEvents Rb_Nome As RadioButton
    Friend WithEvents Rb_Saldo As RadioButton
End Class
