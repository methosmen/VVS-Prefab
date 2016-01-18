namespace WindowsFormsApplication2
{
    partial class TypeTilbud
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cabinetNewQuote = new System.Windows.Forms.Button();
            this.cabinetNewProject = new System.Windows.Forms.Button();
            this.sentralNewQuote = new System.Windows.Forms.Button();
            this.sentralNewProject = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cabinetNewQuote
            // 
            this.cabinetNewQuote.Location = new System.Drawing.Point(106, 77);
            this.cabinetNewQuote.Name = "cabinetNewQuote";
            this.cabinetNewQuote.Size = new System.Drawing.Size(75, 23);
            this.cabinetNewQuote.TabIndex = 0;
            this.cabinetNewQuote.Text = "New quote ";
            this.cabinetNewQuote.UseVisualStyleBackColor = true;
            this.cabinetNewQuote.Click += new System.EventHandler(this.button2_Click);
            // 
            // cabinetNewProject
            // 
            this.cabinetNewProject.Location = new System.Drawing.Point(0, 77);
            this.cabinetNewProject.Name = "cabinetNewProject";
            this.cabinetNewProject.Size = new System.Drawing.Size(75, 23);
            this.cabinetNewProject.TabIndex = 0;
            this.cabinetNewProject.Text = "New project";
            this.cabinetNewProject.UseVisualStyleBackColor = true;
            this.cabinetNewProject.Click += new System.EventHandler(this.button2_Click);
            // 
            // sentralNewQuote
            // 
            this.sentralNewQuote.Location = new System.Drawing.Point(106, 77);
            this.sentralNewQuote.Name = "sentralNewQuote";
            this.sentralNewQuote.Size = new System.Drawing.Size(75, 23);
            this.sentralNewQuote.TabIndex = 0;
            this.sentralNewQuote.Text = "New quote ";
            this.sentralNewQuote.UseVisualStyleBackColor = true;
            this.sentralNewQuote.Click += new System.EventHandler(this.button2_Click);
            // 
            // sentralNewProject
            // 
            this.sentralNewProject.Location = new System.Drawing.Point(0, 77);
            this.sentralNewProject.Name = "sentralNewProject";
            this.sentralNewProject.Size = new System.Drawing.Size(75, 23);
            this.sentralNewProject.TabIndex = 0;
            this.sentralNewProject.Text = "New project";
            this.sentralNewProject.UseVisualStyleBackColor = true;
            this.sentralNewProject.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(53, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sentral";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(53, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Cabinet";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.sentralNewQuote);
            this.groupBox1.Controls.Add(this.sentralNewProject);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 52);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(181, 124);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.cabinetNewProject);
            this.groupBox2.Controls.Add(this.cabinetNewQuote);
            this.groupBox2.Location = new System.Drawing.Point(199, 52);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 124);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox1";
            // 
            // TypeTilbud
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 261);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "TypeTilbud";
            this.Text = "Select type of quote";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button cabinetNewQuote;
        private System.Windows.Forms.Button cabinetNewProject;
        private System.Windows.Forms.Button sentralNewQuote;
        private System.Windows.Forms.Button sentralNewProject;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}