
namespace WinFormsApp30._06._22
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBoxPaint = new System.Windows.Forms.PictureBox();
            this.panelTools = new System.Windows.Forms.Panel();
            this.btnEraser = new System.Windows.Forms.Button();
            this.btnDrawLine = new System.Windows.Forms.Button();
            this.btnDrawRectangle = new System.Windows.Forms.Button();
            this.btnDrawCircle = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.btnColor8 = new System.Windows.Forms.Button();
            this.btnColor4 = new System.Windows.Forms.Button();
            this.btnColor5 = new System.Windows.Forms.Button();
            this.btnColor6 = new System.Windows.Forms.Button();
            this.btnColor7 = new System.Windows.Forms.Button();
            this.btnColor2 = new System.Windows.Forms.Button();
            this.btnColor3 = new System.Windows.Forms.Button();
            this.btnColor1 = new System.Windows.Forms.Button();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.newToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.saveToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.printToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.cutToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.copyToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.pasteToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).BeginInit();
            this.panelTools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBoxPaint
            // 
            this.pictureBoxPaint.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBoxPaint.Location = new System.Drawing.Point(31, 28);
            this.pictureBoxPaint.Name = "pictureBoxPaint";
            this.pictureBoxPaint.Size = new System.Drawing.Size(618, 427);
            this.pictureBoxPaint.TabIndex = 0;
            this.pictureBoxPaint.TabStop = false;
            this.pictureBoxPaint.Click += new System.EventHandler(this.pictureBoxPaint_Click);
            this.pictureBoxPaint.Paint += new System.Windows.Forms.PaintEventHandler(this.pictureBoxPaint_Paint);
            this.pictureBoxPaint.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseClick);
            this.pictureBoxPaint.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseDown);
            this.pictureBoxPaint.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseMove);
            this.pictureBoxPaint.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBoxPaint_MouseUp);
            // 
            // panelTools
            // 
            this.panelTools.AutoSize = true;
            this.panelTools.Controls.Add(this.btnEraser);
            this.panelTools.Controls.Add(this.btnDrawLine);
            this.panelTools.Controls.Add(this.btnDrawRectangle);
            this.panelTools.Controls.Add(this.btnDrawCircle);
            this.panelTools.Controls.Add(this.btnExit);
            this.panelTools.Controls.Add(this.btnClear);
            this.panelTools.Controls.Add(this.label1);
            this.panelTools.Controls.Add(this.trackBar1);
            this.panelTools.Controls.Add(this.btnColor8);
            this.panelTools.Controls.Add(this.btnColor4);
            this.panelTools.Controls.Add(this.btnColor5);
            this.panelTools.Controls.Add(this.btnColor6);
            this.panelTools.Controls.Add(this.btnColor7);
            this.panelTools.Controls.Add(this.btnColor2);
            this.panelTools.Controls.Add(this.btnColor3);
            this.panelTools.Controls.Add(this.btnColor1);
            this.panelTools.Location = new System.Drawing.Point(648, 28);
            this.panelTools.Name = "panelTools";
            this.panelTools.Size = new System.Drawing.Size(155, 427);
            this.panelTools.TabIndex = 1;
            // 
            // btnEraser
            // 
            this.btnEraser.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnEraser.ImageKey = "(нет)";
            this.btnEraser.Location = new System.Drawing.Point(7, 162);
            this.btnEraser.Name = "btnEraser";
            this.btnEraser.Size = new System.Drawing.Size(34, 34);
            this.btnEraser.TabIndex = 14;
            this.btnEraser.Text = "\r\n";
            this.btnEraser.UseVisualStyleBackColor = false;
            this.btnEraser.Click += new System.EventHandler(this.btnEraser_Click);
            this.btnEraser.MouseEnter += new System.EventHandler(this.btnEraser_MouseEnter);
            // 
            // btnDrawLine
            // 
            this.btnDrawLine.ImageKey = "(нет)";
            this.btnDrawLine.Location = new System.Drawing.Point(7, 202);
            this.btnDrawLine.Name = "btnDrawLine";
            this.btnDrawLine.Size = new System.Drawing.Size(34, 34);
            this.btnDrawLine.TabIndex = 13;
            this.btnDrawLine.Text = "\r\n";
            this.btnDrawLine.UseVisualStyleBackColor = true;
            this.btnDrawLine.Click += new System.EventHandler(this.btnDrawLine_Click);
            this.btnDrawLine.MouseEnter += new System.EventHandler(this.btnDrawLine_MouseEnter);
            // 
            // btnDrawRectangle
            // 
            this.btnDrawRectangle.ImageKey = "(нет)";
            this.btnDrawRectangle.Location = new System.Drawing.Point(50, 162);
            this.btnDrawRectangle.Name = "btnDrawRectangle";
            this.btnDrawRectangle.Size = new System.Drawing.Size(34, 34);
            this.btnDrawRectangle.TabIndex = 12;
            this.btnDrawRectangle.Text = "\r\n";
            this.btnDrawRectangle.UseVisualStyleBackColor = true;
            this.btnDrawRectangle.Click += new System.EventHandler(this.btnDrawRectangle_Click);
            this.btnDrawRectangle.MouseEnter += new System.EventHandler(this.btnDrawRectangle_MouseEnter);
            // 
            // btnDrawCircle
            // 
            this.btnDrawCircle.ImageKey = "(нет)";
            this.btnDrawCircle.Location = new System.Drawing.Point(50, 202);
            this.btnDrawCircle.Name = "btnDrawCircle";
            this.btnDrawCircle.Size = new System.Drawing.Size(34, 34);
            this.btnDrawCircle.TabIndex = 3;
            this.btnDrawCircle.Text = "\r\n";
            this.btnDrawCircle.UseVisualStyleBackColor = true;
            this.btnDrawCircle.Click += new System.EventHandler(this.btnDrawCircle_Click);
            this.btnDrawCircle.MouseEnter += new System.EventHandler(this.btnDrawCircle_MouseEnter);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(0, 401);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(152, 23);
            this.btnExit.TabIndex = 11;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(0, 371);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(152, 23);
            this.btnClear.TabIndex = 10;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Толщина линии";
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(4, 125);
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(136, 45);
            this.trackBar1.TabIndex = 8;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // btnColor8
            // 
            this.btnColor8.Location = new System.Drawing.Point(100, 38);
            this.btnColor8.Name = "btnColor8";
            this.btnColor8.Size = new System.Drawing.Size(25, 23);
            this.btnColor8.TabIndex = 7;
            this.btnColor8.UseVisualStyleBackColor = true;
            this.btnColor8.Click += new System.EventHandler(this.btnColor8_Click);
            // 
            // btnColor4
            // 
            this.btnColor4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnColor4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor4.Location = new System.Drawing.Point(100, 9);
            this.btnColor4.Name = "btnColor4";
            this.btnColor4.Size = new System.Drawing.Size(25, 23);
            this.btnColor4.TabIndex = 6;
            this.btnColor4.UseVisualStyleBackColor = false;
            this.btnColor4.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // btnColor5
            // 
            this.btnColor5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btnColor5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor5.Location = new System.Drawing.Point(7, 38);
            this.btnColor5.Name = "btnColor5";
            this.btnColor5.Size = new System.Drawing.Size(25, 23);
            this.btnColor5.TabIndex = 5;
            this.btnColor5.UseVisualStyleBackColor = false;
            this.btnColor5.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // btnColor6
            // 
            this.btnColor6.BackColor = System.Drawing.Color.Blue;
            this.btnColor6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor6.Location = new System.Drawing.Point(38, 38);
            this.btnColor6.Name = "btnColor6";
            this.btnColor6.Size = new System.Drawing.Size(25, 23);
            this.btnColor6.TabIndex = 4;
            this.btnColor6.UseVisualStyleBackColor = false;
            this.btnColor6.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // btnColor7
            // 
            this.btnColor7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.btnColor7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor7.Location = new System.Drawing.Point(69, 38);
            this.btnColor7.Name = "btnColor7";
            this.btnColor7.Size = new System.Drawing.Size(25, 23);
            this.btnColor7.TabIndex = 3;
            this.btnColor7.UseVisualStyleBackColor = false;
            this.btnColor7.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // btnColor2
            // 
            this.btnColor2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btnColor2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor2.Location = new System.Drawing.Point(38, 9);
            this.btnColor2.Name = "btnColor2";
            this.btnColor2.Size = new System.Drawing.Size(25, 23);
            this.btnColor2.TabIndex = 2;
            this.btnColor2.UseVisualStyleBackColor = false;
            this.btnColor2.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // btnColor3
            // 
            this.btnColor3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnColor3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor3.Location = new System.Drawing.Point(69, 9);
            this.btnColor3.Name = "btnColor3";
            this.btnColor3.Size = new System.Drawing.Size(25, 23);
            this.btnColor3.TabIndex = 1;
            this.btnColor3.UseVisualStyleBackColor = false;
            this.btnColor3.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // btnColor1
            // 
            this.btnColor1.BackColor = System.Drawing.Color.Red;
            this.btnColor1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnColor1.Location = new System.Drawing.Point(7, 9);
            this.btnColor1.Name = "btnColor1";
            this.btnColor1.Size = new System.Drawing.Size(25, 23);
            this.btnColor1.TabIndex = 0;
            this.btnColor1.UseVisualStyleBackColor = false;
            this.btnColor1.Click += new System.EventHandler(this.btnColor1_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripButton,
            this.openToolStripButton,
            this.saveToolStripButton,
            this.printToolStripButton,
            this.toolStripSeparator,
            this.cutToolStripButton,
            this.copyToolStripButton,
            this.pasteToolStripButton,
            this.toolStripSeparator1,
            this.helpToolStripButton});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 25);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // newToolStripButton
            // 
            this.newToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.newToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("newToolStripButton.Image")));
            this.newToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newToolStripButton.Name = "newToolStripButton";
            this.newToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.newToolStripButton.Text = "&New";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "&Open";
            this.openToolStripButton.Click += new System.EventHandler(this.openToolStripButton_Click);
            // 
            // saveToolStripButton
            // 
            this.saveToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.saveToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("saveToolStripButton.Image")));
            this.saveToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.saveToolStripButton.Name = "saveToolStripButton";
            this.saveToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.saveToolStripButton.Text = "&Save";
            this.saveToolStripButton.Click += new System.EventHandler(this.saveToolStripButton_Click);
            // 
            // printToolStripButton
            // 
            this.printToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.printToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("printToolStripButton.Image")));
            this.printToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printToolStripButton.Name = "printToolStripButton";
            this.printToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.printToolStripButton.Text = "&Print";
            // 
            // toolStripSeparator
            // 
            this.toolStripSeparator.Name = "toolStripSeparator";
            this.toolStripSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // cutToolStripButton
            // 
            this.cutToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.cutToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("cutToolStripButton.Image")));
            this.cutToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.cutToolStripButton.Name = "cutToolStripButton";
            this.cutToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.cutToolStripButton.Text = "C&ut";
            // 
            // copyToolStripButton
            // 
            this.copyToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.copyToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("copyToolStripButton.Image")));
            this.copyToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.copyToolStripButton.Name = "copyToolStripButton";
            this.copyToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.copyToolStripButton.Text = "&Copy";
            // 
            // pasteToolStripButton
            // 
            this.pasteToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.pasteToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("pasteToolStripButton.Image")));
            this.pasteToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.pasteToolStripButton.Name = "pasteToolStripButton";
            this.pasteToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.pasteToolStripButton.Text = "&Paste";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // helpToolStripButton
            // 
            this.helpToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.helpToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("helpToolStripButton.Image")));
            this.helpToolStripButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.helpToolStripButton.Name = "helpToolStripButton";
            this.helpToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.helpToolStripButton.Text = "He&lp";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.panelTools);
            this.Controls.Add(this.pictureBoxPaint);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPaint)).EndInit();
            this.panelTools.ResumeLayout(false);
            this.panelTools.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxPaint;
        private System.Windows.Forms.Panel panelTools;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Button btnColor8;
        private System.Windows.Forms.Button btnColor4;
        private System.Windows.Forms.Button btnColor5;
        private System.Windows.Forms.Button btnColor6;
        private System.Windows.Forms.Button btnColor7;
        private System.Windows.Forms.Button btnColor2;
        private System.Windows.Forms.Button btnColor3;
        private System.Windows.Forms.Button btnColor1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton newToolStripButton;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolStripButton saveToolStripButton;
        private System.Windows.Forms.ToolStripButton printToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator;
        private System.Windows.Forms.ToolStripButton cutToolStripButton;
        private System.Windows.Forms.ToolStripButton copyToolStripButton;
        private System.Windows.Forms.ToolStripButton pasteToolStripButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton helpToolStripButton;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnDrawCircle;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Button btnEraser;
        private System.Windows.Forms.Button btnDrawLine;
        private System.Windows.Forms.Button btnDrawRectangle;
    }
}

