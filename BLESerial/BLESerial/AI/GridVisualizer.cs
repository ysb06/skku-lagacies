using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BLESerial.AI
{
    public partial class GridVisualizer : UserControl
    {
        private event EventHandler<TileClickedEventArgs> OnTileClicked;
        public event EventHandler<TileClickedEventArgs> TileClicked
        {
            add { OnTileClicked += value; }
            remove { OnTileClicked -= value; }
        }

        private Tile[,] tiles = new Tile[0, 0];

        private Dictionary<Color, Brush> brushList;
        private Dictionary<Color, Brush> stringBrushList;

        [DisplayName("Map Size")]
        public Size MapSize { get; set; }
        [DisplayName("Grid Border Color")]
        public Color GridBorderColor { get; set; }
        [DisplayName("Grid Border Width")]
        public int GridBorderWidth { get; set; }

        public GridVisualizer()
        {
            InitializeComponent();
        }

        private void GridVisualizer_Load(object sender, EventArgs e)
        {
            tiles = new Tile[MapSize.Width, MapSize.Height];
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    tiles[i, j] = new Tile
                    {
                        Text = "",
                        TextColor = Color.Black,
                        RectColor = BackColor
                    };
                }
            }

            brushList = new Dictionary<Color, Brush>();
            stringBrushList = new Dictionary<Color, Brush>();
        }

        private void GridVisualizer_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(BackColor);
            Pen liner = new Pen(GridBorderColor, GridBorderWidth);

            int eWidth = (Width - GridBorderWidth) / MapSize.Width;
            int eHeight = (Height - GridBorderWidth) / MapSize.Height;

            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    tiles[i, j].Rect = new Rectangle(eWidth * i + (GridBorderWidth / 2), eHeight * j + (GridBorderWidth / 2), eWidth, eHeight);

                    if (!stringBrushList.TryGetValue(tiles[i, j].TextColor, out Brush stringBrush))
                    {
                        stringBrush = new SolidBrush(tiles[i, j].TextColor);
                        stringBrushList.Add(tiles[i, j].TextColor, stringBrush);
                    }

                    if (!brushList.TryGetValue(tiles[i, j].RectColor, out Brush brush))
                    {
                        brush = new SolidBrush(tiles[i, j].RectColor);
                        brushList.Add(tiles[i, j].RectColor, brush);
                    }

                    g.FillRectangle(brush, tiles[i, j].Rect);
                    g.DrawRectangle(liner, tiles[i, j].Rect);
                    if(!tiles[i, j].Text.Equals(""))
                    {
                        g.DrawString(tiles[i, j].Text, Font, stringBrush, new Point(
                            tiles[i, j].Rect.X + (tiles[i, j].Rect.Width / 2 - 6), 
                            tiles[i, j].Rect.Y + (tiles[i, j].Rect.Height / 2 - 6)
                            ));
                    }
                }
            }
        }

        public void SetColorAt(int x, int y, Color color)
        {
            tiles[x, y].RectColor = color;
            Invalidate();
        }

        public void SetTextAt(int x, int y, string text)
        {
            tiles[x, y].Text = text;
            Invalidate();
        }

        private void GridVisualizer_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void GridVisualizer_MouseClick(object sender, MouseEventArgs e)
        {
            for (int i = 0; i < tiles.GetLength(0); i++)
            {
                for (int j = 0; j < tiles.GetLength(1); j++)
                {
                    if (tiles[i, j].Rect.Contains(e.Location))
                    {
                        TileClickedEventArgs ne = new TileClickedEventArgs()
                        {
                            ClickedPoint = new Point(i, j)
                        };
                        OnTileClicked(this, ne);
                        break;
                    }
                }
            }
        }

        private void GridVisualizer_Validated(object sender, EventArgs e)
        {
            Console.WriteLine("Validated");
        }
    }

    public struct Tile
    {
        public string Text;
        public Color TextColor;
        public Color RectColor;

        public Rectangle Rect;
    }
}
