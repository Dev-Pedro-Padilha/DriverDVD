namespace DemoDriveInfo
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private global::System.ComponentModel.IContainer components = null;

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
            label1 = new Label();
            label2 = new Label();
            lblDesc = new Label();
            iniciar = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 165);
            label1.Name = "label1";
            label1.Size = new Size(118, 15);
            label1.TabIndex = 0;
            label1.Text = "Tamanho do Arquivo";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(147, 198);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 1;
            label2.Text = "label2";
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point);
            lblDesc.Location = new Point(147, 85);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(110, 45);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "label3";
            // 
            // iniciar
            // 
            iniciar.Location = new Point(402, 314);
            iniciar.Name = "iniciar";
            iniciar.Size = new Size(75, 23);
            iniciar.TabIndex = 3;
            iniciar.Text = "iniciar";
            iniciar.UseVisualStyleBackColor = true;
            iniciar.Click += iniciar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 9);
            label3.Name = "label3";
            label3.Size = new Size(38, 15);
            label3.TabIndex = 4;
            label3.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 24);
            label4.Name = "label4";
            label4.Size = new Size(38, 15);
            label4.TabIndex = 5;
            label4.Text = "label4";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(147, 39);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 7;
            label5.Text = "label5";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(147, 54);
            label6.Name = "label6";
            label6.Size = new Size(38, 15);
            label6.TabIndex = 6;
            label6.Text = "label6";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(iniciar);
            Controls.Add(lblDesc);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label lblDesc;
        private Button iniciar;
        private global::System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
    }
}