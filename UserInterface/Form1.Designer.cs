
namespace UserInterface {
  partial class Form1 {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.removeButton = new System.Windows.Forms.Button();
      this.addButton = new System.Windows.Forms.Button();
      this.viewButton = new System.Windows.Forms.Button();
      this.title = new System.Windows.Forms.Label();
      this.exitButton = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // removeButton
      // 
      this.removeButton.Location = new System.Drawing.Point(331, 93);
      this.removeButton.Name = "removeButton";
      this.removeButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.removeButton.Size = new System.Drawing.Size(130, 62);
      this.removeButton.TabIndex = 1;
      this.removeButton.Text = "Remove Stock";
      this.removeButton.UseVisualStyleBackColor = true;
      this.removeButton.Click += new System.EventHandler(this.button1_Click);
      // 
      // addButton
      // 
      this.addButton.Location = new System.Drawing.Point(168, 93);
      this.addButton.Name = "addButton";
      this.addButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.addButton.Size = new System.Drawing.Size(130, 62);
      this.addButton.TabIndex = 0;
      this.addButton.Text = "Add Stock";
      this.addButton.UseVisualStyleBackColor = true;
      this.addButton.Click += new System.EventHandler(this.button2_Click);
      // 
      // viewButton
      // 
      this.viewButton.Location = new System.Drawing.Point(494, 93);
      this.viewButton.Name = "viewButton";
      this.viewButton.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
      this.viewButton.Size = new System.Drawing.Size(130, 62);
      this.viewButton.TabIndex = 2;
      this.viewButton.Text = "View Stock";
      this.viewButton.UseVisualStyleBackColor = true;
      // 
      // title
      // 
      this.title.AutoSize = true;
      this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.title.Location = new System.Drawing.Point(312, 35);
      this.title.Name = "title";
      this.title.Size = new System.Drawing.Size(169, 36);
      this.title.TabIndex = 3;
      this.title.Text = "Store Stock";
      this.title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // exitButton
      // 
      this.exitButton.BackColor = System.Drawing.SystemColors.WindowText;
      this.exitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
      this.exitButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
      this.exitButton.Location = new System.Drawing.Point(359, 398);
      this.exitButton.Name = "exitButton";
      this.exitButton.Size = new System.Drawing.Size(75, 29);
      this.exitButton.TabIndex = 4;
      this.exitButton.Text = "Exit";
      this.exitButton.UseVisualStyleBackColor = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.exitButton);
      this.Controls.Add(this.title);
      this.Controls.Add(this.viewButton);
      this.Controls.Add(this.addButton);
      this.Controls.Add(this.removeButton);
      this.Name = "Form1";
      this.Text = "Store Stock Application";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Button removeButton;
    private System.Windows.Forms.Button addButton;
    private System.Windows.Forms.Button viewButton;
    private System.Windows.Forms.Label title;
    private System.Windows.Forms.Button exitButton;
  }
}

