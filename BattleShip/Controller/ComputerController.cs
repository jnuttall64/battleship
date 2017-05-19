﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using BattleShip.Model;
using System.Windows.Forms;

namespace BattleShip.Controller
{
    class ComputerController
    {
        private List<Ship> ships;
        private List<int> amounts;
        public List<Point> positions;
        public ComputerController()
        {
            amounts = new List<int>();
            positions = new List<Point>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    positions.Add(new Point { X = i, Y = j });
                }
            }
            amounts.Add(3);
            amounts.Add(2);
            amounts.Add(2);
            amounts.Add(1);
            amounts.Add(1);
            Random();
        }

        public void SetGridView(DataGridView grid)
        {
            grid.Rows.Clear();
            grid.RowCount = 10;
            grid.ColumnCount = 10; ;
            for (int i = 0; i < 10; i++)
            {
                grid.Rows[i].Height = 36;
                grid.Columns[i].Width = 36;
            }
            
            grid.ClearSelection();
        }

        public void RemoveDeadPoints(Point position)
        {
            positions.Remove(new Point { X = position.X - 1, Y = position.Y - 1 });
            positions.Remove(new Point { X = position.X - 1, Y = position.Y + 1 });
            positions.Remove(new Point { X = position.X + 1, Y = position.Y - 1 });
            positions.Remove(new Point { X = position.X + 1, Y = position.Y + 1 });
        }

        public void RemoveDeadShip(Ship selected)
        {
            foreach (Point point in selected.viewPoints)
            {
                positions.Remove(point);
            }
        }

        public bool Shoot(Point position, DataGridView grid)
        {
            grid.Enabled = true;
            if(positions.Contains(position))
            {
                positions.Remove(position);
                foreach (Ship ship in ships)
                {
                    if (ship.ExistPosition(position))
                    {
                        ship.ShootPosition(position);
                        if (ship.Destroyed())
                        {
                            RemoveDeadShip(ship);
                        }
                        else
                        {
                            RemoveDeadPoints(position);
                        }                       
                        System.Media.SoundPlayer sound2 = new System.Media.SoundPlayer(Properties.Resources.explosion);
                        sound2.Play();
                        grid.Rows[position.X].Cells[position.Y].Style.BackColor = Color.Red;
                        ShowShips(grid);
                        grid.Enabled = false;
                        return false;
                    }
                }
                DataGridViewImageCell imgCell = new DataGridViewImageCell();
                imgCell.Value = Properties.Resources.missImage;
                grid.Rows[position.X].Cells[position.Y] = imgCell;

                grid.Enabled = false;
                System.Media.SoundPlayer sound = new System.Media.SoundPlayer(Properties.Resources.miss);
                sound.Play();
                return true;
            }
            return false;
        }
        public void ShowShips(DataGridView grid)
        {
            ships.ForEach(ship => ship.enemyShipsDraw(grid));
        }
        public bool Won() {

            return ships.All(ship => ship.Destroyed());
        }
        public void Random()
        {
            ships = new List<Ship>();
            //ships.Add(new Ship(1, Color.Black, new Point { X = 0, Y = 0 }, Ship.View.HORIZONTAL));
            
            bool picked = false;
            for (int i = 4; i >= 0; i--)
            {
                for (int j = 0; j < amounts[i]; j++)
                {
                    while (!picked)
                    {
                        int index = new Random().Next(positions.Count);
                        Ship.View type = (Ship.View)new Random().Next(2);
                        Point position = positions[index];

                        Ship primary = new Ship(i + 1, Color.Blue, position, type);
                        if (!ships.Exists(ship => ship.ExistShip(primary)))
                        {
                                ships.Add(primary);
                                picked = true;
                                RemovePositions(primary);
                        }                        
                    }
                    picked = false;
                }
            }
            positions = new List<Point>();
            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    positions.Add(new Point { X = i, Y = j });
                }
            }
        }

        private void RemovePositions(Ship primary)
        {
            foreach (Point point in primary.viewPoints)
            {
                positions.Remove(point);
            }
        }
    }
}