namespace Practica_2
{
    partial class Form1
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
            extInput = new TextBox();
            listView = new ListView();
            addExtBtn = new Button();
            errorExt = new Label();
            filesSelector = new FolderBrowserDialog();
            fileSelectorBtn = new Button();
            folderLabel = new Label();
            listFilesFront = new ListBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // extInput
            // 
            extInput.Location = new Point(12, 111);
            extInput.Name = "extInput";
            extInput.Size = new Size(260, 27);
            extInput.TabIndex = 0;
            // 
            // listView
            // 
            listView.Location = new Point(13, 144);
            listView.Name = "listView";
            listView.Size = new Size(259, 284);
            listView.TabIndex = 1;
            listView.UseCompatibleStateImageBehavior = false;
            // 
            // addExtBtn
            // 
            addExtBtn.Location = new Point(278, 109);
            addExtBtn.Name = "addExtBtn";
            addExtBtn.Size = new Size(137, 29);
            addExtBtn.TabIndex = 2;
            addExtBtn.Text = "Agregar";
            addExtBtn.UseVisualStyleBackColor = true;
            addExtBtn.Click += addExtBtn_Click;
            // 
            // errorExt
            // 
            errorExt.AutoSize = true;
            errorExt.ForeColor = Color.Red;
            errorExt.Location = new Point(421, 85);
            errorExt.Name = "errorExt";
            errorExt.Size = new Size(0, 20);
            errorExt.TabIndex = 3;
            // 
            // fileSelectorBtn
            // 
            fileSelectorBtn.Location = new Point(13, 28);
            fileSelectorBtn.Name = "fileSelectorBtn";
            fileSelectorBtn.Size = new Size(259, 29);
            fileSelectorBtn.TabIndex = 4;
            fileSelectorBtn.Text = "Seleccionar carpeta";
            fileSelectorBtn.UseVisualStyleBackColor = true;
            fileSelectorBtn.Click += fileSelectorBtn_Click;
            // 
            // folderLabel
            // 
            folderLabel.AutoSize = true;
            folderLabel.Location = new Point(278, 32);
            folderLabel.Name = "folderLabel";
            folderLabel.Size = new Size(0, 20);
            folderLabel.TabIndex = 5;
            // 
            // listFilesFront
            // 
            listFilesFront.FormattingEnabled = true;
            listFilesFront.HorizontalScrollbar = true;
            listFilesFront.Location = new Point(421, 144);
            listFilesFront.Name = "listFilesFront";
            listFilesFront.Size = new Size(759, 284);
            listFilesFront.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(422, 121);
            label1.Name = "label1";
            label1.Size = new Size(142, 20);
            label1.TabIndex = 7;
            label1.Text = "Archivos eliminados";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(13, 88);
            label2.Name = "label2";
            label2.Size = new Size(159, 20);
            label2.TabIndex = 8;
            label2.Text = "Extensiones maliciosas";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1192, 457);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listFilesFront);
            Controls.Add(folderLabel);
            Controls.Add(fileSelectorBtn);
            Controls.Add(errorExt);
            Controls.Add(addExtBtn);
            Controls.Add(listView);
            Controls.Add(extInput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox extInput;
        private ListView listView;
        private Button addExtBtn;
        private Label errorExt;
        private FolderBrowserDialog filesSelector;
        private Button fileSelectorBtn;
        private Label folderLabel;
        private ListBox listFilesFront;
        private Label label1;
        private Label label2;
    }
}
