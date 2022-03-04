
namespace Haromszogek
{
    partial class Form1
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
            this.btnLoad = new System.Windows.Forms.Button();
            this.gbErrors = new System.Windows.Forms.GroupBox();
            this.gbTriangles = new System.Windows.Forms.GroupBox();
            this.lbTriangles = new System.Windows.Forms.ListBox();
            this.gbDatas = new System.Windows.Forms.GroupBox();
            this.lbDatas = new System.Windows.Forms.ListBox();
            this.gbTriangles.SuspendLayout();
            this.gbDatas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLoad
            // 
            this.btnLoad.Location = new System.Drawing.Point(12, 12);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(103, 40);
            this.btnLoad.TabIndex = 0;
            this.btnLoad.Text = "Adatok betöltése";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // gbErrors
            // 
            this.gbErrors.Location = new System.Drawing.Point(12, 58);
            this.gbErrors.Name = "gbErrors";
            this.gbErrors.Size = new System.Drawing.Size(528, 118);
            this.gbErrors.TabIndex = 1;
            this.gbErrors.TabStop = false;
            this.gbErrors.Text = "Hibák a kiválasztott állományban!";
            // 
            // gbTriangles
            // 
            this.gbTriangles.Controls.Add(this.lbTriangles);
            this.gbTriangles.Location = new System.Drawing.Point(12, 182);
            this.gbTriangles.Name = "gbTriangles";
            this.gbTriangles.Size = new System.Drawing.Size(200, 215);
            this.gbTriangles.TabIndex = 2;
            this.gbTriangles.TabStop = false;
            this.gbTriangles.Text = "Derékszögű háromszögek";
            // 
            // lbTriangles
            // 
            this.lbTriangles.FormattingEnabled = true;
            this.lbTriangles.Location = new System.Drawing.Point(6, 19);
            this.lbTriangles.Name = "lbTriangles";
            this.lbTriangles.Size = new System.Drawing.Size(188, 186);
            this.lbTriangles.TabIndex = 0;
            this.lbTriangles.SelectedIndexChanged += new System.EventHandler(this.lbTriangles_SelectedIndexChanged);
            // 
            // gbDatas
            // 
            this.gbDatas.Controls.Add(this.lbDatas);
            this.gbDatas.Location = new System.Drawing.Point(242, 182);
            this.gbDatas.Name = "gbDatas";
            this.gbDatas.Size = new System.Drawing.Size(298, 100);
            this.gbDatas.TabIndex = 3;
            this.gbDatas.TabStop = false;
            this.gbDatas.Text = "Kiválasztott derékszögű háromszög adatai";
            // 
            // lbDatas
            // 
            this.lbDatas.FormattingEnabled = true;
            this.lbDatas.Location = new System.Drawing.Point(6, 19);
            this.lbDatas.Name = "lbDatas";
            this.lbDatas.Size = new System.Drawing.Size(286, 69);
            this.lbDatas.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 409);
            this.Controls.Add(this.gbDatas);
            this.Controls.Add(this.gbTriangles);
            this.Controls.Add(this.gbErrors);
            this.Controls.Add(this.btnLoad);
            this.Name = "Form1";
            this.Text = "Derékszögű háromszögek";
            this.gbTriangles.ResumeLayout(false);
            this.gbDatas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.GroupBox gbErrors;
        private System.Windows.Forms.GroupBox gbTriangles;
        private System.Windows.Forms.GroupBox gbDatas;
        private System.Windows.Forms.ListBox lbTriangles;
        private System.Windows.Forms.ListBox lbDatas;
    }
}

