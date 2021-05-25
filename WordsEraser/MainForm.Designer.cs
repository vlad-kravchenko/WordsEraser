namespace WordsEraser
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnReplace = new System.Windows.Forms.Button();
            this.tbSource = new System.Windows.Forms.RichTextBox();
            this.tbResult = new System.Windows.Forms.RichTextBox();
            this.tbFrequency = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnReplace
            // 
            this.btnReplace.Location = new System.Drawing.Point(118, 12);
            this.btnReplace.Name = "btnReplace";
            this.btnReplace.Size = new System.Drawing.Size(854, 23);
            this.btnReplace.TabIndex = 0;
            this.btnReplace.Text = "Replace words";
            this.btnReplace.UseVisualStyleBackColor = true;
            this.btnReplace.Click += new System.EventHandler(this.btnReplace_Click);
            // 
            // tbSource
            // 
            this.tbSource.Location = new System.Drawing.Point(12, 41);
            this.tbSource.Name = "tbSource";
            this.tbSource.Size = new System.Drawing.Size(960, 327);
            this.tbSource.TabIndex = 1;
            this.tbSource.Text = "";
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(12, 374);
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(960, 275);
            this.tbResult.TabIndex = 2;
            this.tbResult.Text = "";
            // 
            // tbFrequency
            // 
            this.tbFrequency.Location = new System.Drawing.Point(12, 12);
            this.tbFrequency.Name = "tbFrequency";
            this.tbFrequency.Size = new System.Drawing.Size(100, 20);
            this.tbFrequency.TabIndex = 3;
            this.tbFrequency.Text = "90";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.tbFrequency);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.tbSource);
            this.Controls.Add(this.btnReplace);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "WordsEraser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnReplace;
        private System.Windows.Forms.RichTextBox tbSource;
        private System.Windows.Forms.RichTextBox tbResult;
        private System.Windows.Forms.TextBox tbFrequency;
    }
}

