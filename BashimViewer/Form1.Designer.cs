namespace BashimViewer
{
    partial class Form1
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
            this.richTextBoxCurrentQuote = new System.Windows.Forms.RichTextBox();
            this.labelInfo = new System.Windows.Forms.Label();
            this.buttonMovePrev = new System.Windows.Forms.Button();
            this.buttonMoveNext = new System.Windows.Forms.Button();
            this.buttonLoadQuotes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTextBoxCurrentQuote
            // 
            this.richTextBoxCurrentQuote.Location = new System.Drawing.Point(13, 13);
            this.richTextBoxCurrentQuote.Name = "richTextBoxCurrentQuote";
            this.richTextBoxCurrentQuote.Size = new System.Drawing.Size(586, 344);
            this.richTextBoxCurrentQuote.TabIndex = 0;
            this.richTextBoxCurrentQuote.Text = "";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(286, 409);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(35, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "label1";
            // 
            // buttonMovePrev
            // 
            this.buttonMovePrev.Location = new System.Drawing.Point(12, 409);
            this.buttonMovePrev.Name = "buttonMovePrev";
            this.buttonMovePrev.Size = new System.Drawing.Size(75, 23);
            this.buttonMovePrev.TabIndex = 2;
            this.buttonMovePrev.Text = "MovePrev";
            this.buttonMovePrev.UseVisualStyleBackColor = true;
            this.buttonMovePrev.Click += new System.EventHandler(this.buttonMovePrev_Click);
            // 
            // buttonMoveNext
            // 
            this.buttonMoveNext.Location = new System.Drawing.Point(523, 409);
            this.buttonMoveNext.Name = "buttonMoveNext";
            this.buttonMoveNext.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveNext.TabIndex = 3;
            this.buttonMoveNext.Text = "MoveNext";
            this.buttonMoveNext.UseVisualStyleBackColor = true;
            this.buttonMoveNext.Click += new System.EventHandler(this.buttonMoveNext_Click);
            // 
            // buttonLoadQuotes
            // 
            this.buttonLoadQuotes.Location = new System.Drawing.Point(263, 363);
            this.buttonLoadQuotes.Name = "buttonLoadQuotes";
            this.buttonLoadQuotes.Size = new System.Drawing.Size(75, 23);
            this.buttonLoadQuotes.TabIndex = 4;
            this.buttonLoadQuotes.Text = "LoadQuotes";
            this.buttonLoadQuotes.UseVisualStyleBackColor = true;
            this.buttonLoadQuotes.Click += new System.EventHandler(this.buttonLoadQuotes_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 465);
            this.Controls.Add(this.buttonLoadQuotes);
            this.Controls.Add(this.buttonMoveNext);
            this.Controls.Add(this.buttonMovePrev);
            this.Controls.Add(this.labelInfo);
            this.Controls.Add(this.richTextBoxCurrentQuote);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxCurrentQuote;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.Button buttonMovePrev;
        private System.Windows.Forms.Button buttonMoveNext;
        private System.Windows.Forms.Button buttonLoadQuotes;
    }
}

