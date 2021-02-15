
namespace Test.TextEditor
{
    partial class StartForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StartForm));
            this.lblFilePath = new System.Windows.Forms.Label();
            this.tBoxFilePath = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnSelectFile = new System.Windows.Forms.Button();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.tBoxFontSize = new System.Windows.Forms.NumericUpDown();
            this.tBoxContent = new System.Windows.Forms.TextBox();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.sSLblSymCountDescription = new System.Windows.Forms.ToolStripStatusLabel();
            this.sSLblSymbolsCountPrintOut = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.tBoxFontSize)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblFilePath
            // 
            this.lblFilePath.Font = new System.Drawing.Font("Times New Roman", 10F);
            this.lblFilePath.Location = new System.Drawing.Point(14, 14);
            this.lblFilePath.Margin = new System.Windows.Forms.Padding(5);
            this.lblFilePath.Name = "lblFilePath";
            this.lblFilePath.Size = new System.Drawing.Size(100, 24);
            this.lblFilePath.TabIndex = 0;
            this.lblFilePath.Text = "Выберите файл:";
            this.lblFilePath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxFilePath
            // 
            this.tBoxFilePath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxFilePath.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.tBoxFilePath.Location = new System.Drawing.Point(124, 16);
            this.tBoxFilePath.Margin = new System.Windows.Forms.Padding(5);
            this.tBoxFilePath.Name = "tBoxFilePath";
            this.tBoxFilePath.Size = new System.Drawing.Size(486, 21);
            this.tBoxFilePath.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOpenFile.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnOpenFile.Location = new System.Drawing.Point(700, 14);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(5);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(70, 24);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "Открыть";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            // 
            // btnSelectFile
            // 
            this.btnSelectFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelectFile.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.btnSelectFile.Location = new System.Drawing.Point(620, 14);
            this.btnSelectFile.Margin = new System.Windows.Forms.Padding(5);
            this.btnSelectFile.Name = "btnSelectFile";
            this.btnSelectFile.Size = new System.Drawing.Size(70, 24);
            this.btnSelectFile.TabIndex = 3;
            this.btnSelectFile.Text = "Выбрать";
            this.btnSelectFile.UseVisualStyleBackColor = true;
            // 
            // lblFontSize
            // 
            this.lblFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblFontSize.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.lblFontSize.Location = new System.Drawing.Point(11, 505);
            this.lblFontSize.Margin = new System.Windows.Forms.Padding(5);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(53, 24);
            this.lblFontSize.TabIndex = 4;
            this.lblFontSize.Text = "Шрифт";
            this.lblFontSize.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // tBoxFontSize
            // 
            this.tBoxFontSize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tBoxFontSize.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tBoxFontSize.Font = new System.Drawing.Font("Times New Roman", 9.75F);
            this.tBoxFontSize.Location = new System.Drawing.Point(74, 508);
            this.tBoxFontSize.Margin = new System.Windows.Forms.Padding(5);
            this.tBoxFontSize.Maximum = new decimal(new int[] {
            72,
            0,
            0,
            0});
            this.tBoxFontSize.Minimum = new decimal(new int[] {
            6,
            0,
            0,
            0});
            this.tBoxFontSize.Name = "tBoxFontSize";
            this.tBoxFontSize.Size = new System.Drawing.Size(53, 22);
            this.tBoxFontSize.TabIndex = 5;
            this.tBoxFontSize.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.tBoxFontSize.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
            // 
            // tBoxContent
            // 
            this.tBoxContent.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tBoxContent.Font = new System.Drawing.Font("Times New Roman", 9F);
            this.tBoxContent.Location = new System.Drawing.Point(17, 47);
            this.tBoxContent.Margin = new System.Windows.Forms.Padding(5);
            this.tBoxContent.Multiline = true;
            this.tBoxContent.Name = "tBoxContent";
            this.tBoxContent.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tBoxContent.Size = new System.Drawing.Size(756, 447);
            this.tBoxContent.TabIndex = 6;
            this.tBoxContent.TextChanged += new System.EventHandler(this.tBoxContent_TextChanged_1);
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSaveFile.BackColor = System.Drawing.SystemColors.Control;
            this.btnSaveFile.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control;
            this.btnSaveFile.FlatAppearance.BorderSize = 0;
            this.btnSaveFile.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnSaveFile.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold);
            this.btnSaveFile.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSaveFile.Location = new System.Drawing.Point(690, 505);
            this.btnSaveFile.Margin = new System.Windows.Forms.Padding(5);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(80, 24);
            this.btnSaveFile.TabIndex = 7;
            this.btnSaveFile.Text = "Сохранить";
            this.btnSaveFile.UseVisualStyleBackColor = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sSLblSymCountDescription,
            this.sSLblSymbolsCountPrintOut});
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(784, 22);
            this.statusStrip1.TabIndex = 8;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // sSLblSymCountDescription
            // 
            this.sSLblSymCountDescription.Name = "sSLblSymCountDescription";
            this.sSLblSymCountDescription.Size = new System.Drawing.Size(86, 17);
            this.sSLblSymCountDescription.Text = "Symbols count";
            // 
            // sSLblSymbolsCountPrintOut
            // 
            this.sSLblSymbolsCountPrintOut.Name = "sSLblSymbolsCountPrintOut";
            this.sSLblSymbolsCountPrintOut.Size = new System.Drawing.Size(0, 17);
            // 
            // StartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.tBoxContent);
            this.Controls.Add(this.tBoxFontSize);
            this.Controls.Add(this.lblFontSize);
            this.Controls.Add(this.btnSelectFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.tBoxFilePath);
            this.Controls.Add(this.lblFilePath);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(400, 200);
            this.Name = "StartForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Текстовый редактор";
            ((System.ComponentModel.ISupportInitialize)(this.tBoxFontSize)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFilePath;
        private System.Windows.Forms.TextBox tBoxFilePath;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnSelectFile;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.NumericUpDown tBoxFontSize;
        private System.Windows.Forms.TextBox tBoxContent;
        private System.Windows.Forms.Button btnSaveFile;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel sSLblSymCountDescription;
        private System.Windows.Forms.ToolStripStatusLabel sSLblSymbolsCountPrintOut;
    }
}

