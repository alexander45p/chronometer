namespace chronometer
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.txtmin = new System.Windows.Forms.TextBox();
            this.txtseg = new System.Windows.Forms.TextBox();
            this.txtmil = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtmin
            // 
            this.txtmin.Location = new System.Drawing.Point(14, 45);
            this.txtmin.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmin.MaximumSize = new System.Drawing.Size(641, 500);
            this.txtmin.MinimumSize = new System.Drawing.Size(58, 4);
            this.txtmin.Name = "txtmin";
            this.txtmin.Size = new System.Drawing.Size(150, 21);
            this.txtmin.TabIndex = 0;
            // 
            // txtseg
            // 
            this.txtseg.Location = new System.Drawing.Point(190, 45);
            this.txtseg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtseg.Name = "txtseg";
            this.txtseg.Size = new System.Drawing.Size(130, 21);
            this.txtseg.TabIndex = 1;
            // 
            // txtmil
            // 
            this.txtmil.Location = new System.Drawing.Point(338, 45);
            this.txtmil.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtmil.Name = "txtmil";
            this.txtmil.Size = new System.Drawing.Size(116, 21);
            this.txtmil.TabIndex = 2;
            this.txtmil.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button2.Location = new System.Drawing.Point(338, 89);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 40);
            this.button2.TabIndex = 4;
            this.button2.Text = "PLAY";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(190, 89);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(92, 40);
            this.button3.TabIndex = 5;
            this.button3.Text = "STOP";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Red;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.button4.FlatAppearance.BorderSize = 2;
            this.button4.Location = new System.Drawing.Point(41, 89);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(98, 40);
            this.button4.TabIndex = 6;
            this.button4.Text = "PAUSE";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(464, 160);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtmil);
            this.Controls.Add(this.txtseg);
            this.Controls.Add(this.txtmin);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "chronometer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtmin;
        private System.Windows.Forms.TextBox txtseg;
        private System.Windows.Forms.TextBox txtmil;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

