namespace Portal_do_Aluno
{
    partial class form
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txt_nome1 = new TextBox();
            txt_nome2 = new TextBox();
            txt_nome3 = new TextBox();
            button1 = new Button();
            panel1 = new Panel();
            label5 = new Label();
            lv_alunos = new ListView();
            Nome = new ColumnHeader();
            Idade = new ColumnHeader();
            Curso = new ColumnHeader();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.HighlightText;
            label1.Location = new Point(118, 19);
            label1.Name = "label1";
            label1.Size = new Size(344, 86);
            label1.TabIndex = 0;
            label1.Text = "Formulario";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.HighlightText;
            label2.Location = new Point(118, 199);
            label2.Name = "label2";
            label2.Size = new Size(211, 86);
            label2.TabIndex = 1;
            label2.Text = "Nome";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.HighlightText;
            label3.Location = new Point(118, 331);
            label3.Name = "label3";
            label3.Size = new Size(196, 86);
            label3.TabIndex = 2;
            label3.Text = "Idade";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = SystemColors.HighlightText;
            label4.Location = new Point(114, 458);
            label4.Name = "label4";
            label4.Size = new Size(200, 86);
            label4.TabIndex = 3;
            label4.Text = "Curso";
            // 
            // txt_nome1
            // 
            txt_nome1.Location = new Point(141, 305);
            txt_nome1.Name = "txt_nome1";
            txt_nome1.Size = new Size(259, 23);
            txt_nome1.TabIndex = 4;
            // 
            // txt_nome2
            // 
            txt_nome2.Location = new Point(141, 432);
            txt_nome2.Name = "txt_nome2";
            txt_nome2.Size = new Size(259, 23);
            txt_nome2.TabIndex = 5;
            // 
            // txt_nome3
            // 
            txt_nome3.Location = new Point(141, 547);
            txt_nome3.Name = "txt_nome3";
            txt_nome3.Size = new Size(259, 23);
            txt_nome3.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(192, 597);
            button1.Name = "button1";
            button1.Size = new Size(137, 40);
            button1.TabIndex = 7;
            button1.Text = "Cadastrar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Button1_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(lv_alunos);
            panel1.Location = new Point(468, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(558, 661);
            panel1.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = SystemColors.Desktop;
            label5.Location = new Point(15, 21);
            label5.Name = "label5";
            label5.Size = new Size(466, 86);
            label5.TabIndex = 9;
            label5.Text = "Lista de Alunos";
            // 
            // lv_alunos
            // 
            lv_alunos.Columns.AddRange(new ColumnHeader[] { Nome, Idade, Curso });
            lv_alunos.Location = new Point(47, 136);
            lv_alunos.Name = "lv_alunos";
            lv_alunos.Size = new Size(466, 485);
            lv_alunos.TabIndex = 0;
            lv_alunos.UseCompatibleStateImageBehavior = false;
            lv_alunos.View = View.Details;
            // 
            // Nome
            // 
            Nome.Text = "Nome";
            Nome.Width = 120;
            // 
            // Idade
            // 
            Idade.Text = "Idade";
            // 
            // Curso
            // 
            Curso.Text = "Curso";
            Curso.Width = 250;
            // 
            // form
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1025, 658);
            Controls.Add(panel1);
            Controls.Add(button1);
            Controls.Add(txt_nome3);
            Controls.Add(txt_nome2);
            Controls.Add(txt_nome1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "form";
            Text = "Portal";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txt_nome1;
        private TextBox txt_nome2;
        private TextBox textBox2;
        private TextBox txt_nome3;
        private Button button1;
        private Panel panel1;
        private ListView lv_alunos;
        private ColumnHeader Nome;
        private ColumnHeader Idade;
        private ColumnHeader Curso;
        private Label label5;
    }
}
