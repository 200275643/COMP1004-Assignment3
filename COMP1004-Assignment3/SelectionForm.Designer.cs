namespace COMP1004_Assignment3
{
    partial class SelectionForm
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
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.YourSelectionGroupBox = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Items.AddRange(new object[] {
            "Aaru",
            "Arya",
            "Athadu",
            "BasketBall Dairies",
            "Doctor Strange",
            "Fight Club",
            "Inception",
            "Lion",
            "Ontari",
            "Piglet",
            "Pokiri",
            "Simha",
            "Sindhuram",
            "Solo"});
            this.listBox1.Location = new System.Drawing.Point(12, 54);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(132, 134);
            this.listBox1.Sorted = true;
            this.listBox1.TabIndex = 0;
            // 
            // YourSelectionGroupBox
            // 
            this.YourSelectionGroupBox.Location = new System.Drawing.Point(159, 64);
            this.YourSelectionGroupBox.Name = "YourSelectionGroupBox";
            this.YourSelectionGroupBox.Size = new System.Drawing.Size(304, 210);
            this.YourSelectionGroupBox.TabIndex = 1;
            this.YourSelectionGroupBox.TabStop = false;
            this.YourSelectionGroupBox.Text = "YourSelection";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Sans", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Choose the movie you wish to Stream from below";
            // 
            // SelectionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(489, 286);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.YourSelectionGroupBox);
            this.Controls.Add(this.listBox1);
            this.Name = "SelectionForm";
            this.Text = "SelectionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox YourSelectionGroupBox;
        private System.Windows.Forms.Label label1;
    }
}

