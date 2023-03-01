using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using WindowsFormsApp1;

public class Form1 : Form
{
	private string[] 棋子数组基础 = new string[9] { "车", "马", "象", "士", "帅", "士", "象", "马", "车" };

	private IContainer components = null;

	private PictureBox picBack;

	private Label label1;

	private Label label2;

	private void 初始化棋子(Color 背景颜色, int 偏移Y值)
	{
		int num = 0;
		int num2 = 40;
		string[] array = 棋子数组基础;
		foreach (string 文本 in array)
		{
			Button button = 标准棋子按钮(背景颜色, 文本);
			button.Location = new Point(num2 + num * 107, 90);
			if (偏移Y值 != 0)
			{
				button.Location = new Point(num2 + num * 107, picBack.Height - 90 - 偏移Y值);
			}
			button.MouseMove += 棋子事件MouseMove;
			picBack.Controls.Add(button);
			num++;
		}
		num = 1;
		for (int j = 0; j < 2; j++)
		{
			Button button2 = 标准棋子按钮(背景颜色, "炮");
			button2.Location = new Point(num2 + num * 107, 250);
			if (偏移Y值 != 0)
			{
				button2.Location = new Point(num2 + num * 107, picBack.Height - 250 - 偏移Y值);
			}
			button2.MouseMove += 棋子事件MouseMove;
			picBack.Controls.Add(button2);
			num += 6;
		}
		num = 0;
		for (int k = 0; k < 5; k++)
		{
			Button button3 = 标准棋子按钮(背景颜色, "卒");
			button3.Location = new Point(num2 + num * 107, 310);
			if (偏移Y值 != 0)
			{
				button3.Location = new Point(num2 + num * 107, picBack.Height - 330 - 偏移Y值);
			}
			button3.MouseMove += 棋子事件MouseMove;
			picBack.Controls.Add(button3);
			num += 2;
		}
	}

	private Button 标准棋子按钮(Color 背景颜色, string 文本)
	{
		Button button = new Button();
		button.Width = 50;
		button.Height = 50;
		button.Text = 文本;
		button.BackColor = 背景颜色;
		return button;
	}

	public Form1()
	{
		InitializeComponent();
		初始化棋子(Color.Beige, 0);
		初始化棋子(Color.AliceBlue, 40);
	}

	private void 棋子事件MouseMove(object sender, MouseEventArgs e)
	{
		if (e.Button == MouseButtons.Left)
		{
			Button button = (Button)sender;
			int num = button.Size.Width / 2;
			Console.WriteLine($"X:{e.X};Y:{e.Y}");
			button.Location = new Point(button.Location.X + e.X - num, button.Location.Y + e.Y - num);
		}
	}

	protected override void Dispose(bool disposing)
	{
		if (disposing && components != null)
		{
			components.Dispose();
		}
		base.Dispose(disposing);
	}

	private void InitializeComponent()
	{
		System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WindowsFormsApp1.Form1));
		this.picBack = new System.Windows.Forms.PictureBox();
		this.label1 = new System.Windows.Forms.Label();
		this.label2 = new System.Windows.Forms.Label();
		((System.ComponentModel.ISupportInitialize)this.picBack).BeginInit();
		base.SuspendLayout();
		this.picBack.Image = (System.Drawing.Image)resources.GetObject("picBack.Image");
		this.picBack.Location = new System.Drawing.Point(0, 0);
		this.picBack.Name = "picBack";
		this.picBack.Size = new System.Drawing.Size(1170, 961);
		this.picBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
		this.picBack.TabIndex = 0;
		this.picBack.TabStop = false;
		this.label1.AutoSize = true;
		this.label1.BackColor = System.Drawing.Color.White;
		this.label1.Font = new System.Drawing.Font("宋体", 14f);
		this.label1.Location = new System.Drawing.Point(523, 909);
		this.label1.Name = "label1";
		this.label1.Size = new System.Drawing.Size(390, 19);
		this.label1.TabIndex = 1;
		this.label1.Text = "123";
		this.label2.AutoSize = true;
		this.label2.BackColor = System.Drawing.Color.White;
		this.label2.Font = new System.Drawing.Font("宋体", 24f);
		this.label2.ForeColor = System.Drawing.Color.Red;
		this.label2.Location = new System.Drawing.Point(163, 897);
		this.label2.Name = "label2";
		this.label2.Size = new System.Drawing.Size(0, 33);
		this.label2.TabIndex = 2;
		base.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
		base.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
		this.BackColor = System.Drawing.SystemColors.ActiveCaption;
		base.ClientSize = new System.Drawing.Size(1163, 961);
		base.Controls.Add(this.label2);
		base.Controls.Add(this.label1);
		base.Controls.Add(this.picBack);
		base.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
		base.MaximizeBox = false;
		base.Name = "Form1";
		base.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
		this.Text = "Form1";
		((System.ComponentModel.ISupportInitialize)this.picBack).EndInit();
		base.ResumeLayout(false);
		base.PerformLayout();
	}
}
