using System.Drawing;
using System.Windows.Forms;

class KareRadioButton : RadioButton
{
    public KareRadioButton()
    {
        disRenk = Color.FromArgb(44, 44, 44);
        icRenk = Color.FromArgb(44, 44, 44);
        Font = new Font("Microsoft Sans Serif", 9F);
        SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        BackColor = Color.Transparent;
    }

    public Color icRenk { get; set; }
    public Color disRenk { get; set; }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        Graphics g = pevent.Graphics;
        g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        PaintParentBackground(pevent);
        int diameter = ClientRectangle.Height - 1;

        RectangleF innerRect = new RectangleF(1F, 1F, diameter - 2, diameter - 2);
        g.FillRectangle(new SolidBrush(Color.White), innerRect);

        Rectangle outerRect = new Rectangle(0, 0, diameter, diameter);
        g.DrawRectangle(new Pen(disRenk), outerRect);

        if (Checked)
        {
            innerRect.Inflate(-3, -3);
            g.FillRectangle(new SolidBrush(icRenk), innerRect);
        }

        g.DrawString(Text, Font, new SolidBrush(ForeColor), diameter + 5, 1);
    }

    private void PaintParentBackground(PaintEventArgs e)
    {
        if (Parent == null)
        {
            e.Graphics.FillRectangle(SystemBrushes.Control, ClientRectangle);
            return;
        }

        Rectangle rect = new Rectangle(Left, Top, Width, Height);
        e.Graphics.TranslateTransform(-rect.X, -rect.Y);

        try
        {
            using (PaintEventArgs pea = new PaintEventArgs(e.Graphics, rect))
            {
                pea.Graphics.SetClip(rect);
                InvokePaintBackground(Parent, pea);
                InvokePaint(Parent, pea);
            }
        }
        finally
        {
            e.Graphics.TranslateTransform(rect.X, rect.Y);
        }
    }
}