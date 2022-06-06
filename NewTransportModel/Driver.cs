using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Laba_5.model
{
    public class Driver : ModelActingElement
    {
        // имя водителя
        private string name;
        // троллейбус, на котором водитель работает
        private Trolleybus trolleybus;

        public string Name { get { return name; } }

        // метод для получения точки для водителя в автобусе
        private Point GetTrolleyPoint()
        {
            return new Point(trolleybus.Point.X, trolleybus.Point.Y + 70);
        }

        public Driver(string name, Trolleybus trolleybus, Action<string> notification) : base(notification)
        {
            this.name = name;
            this.trolleybus = trolleybus;
            this.Point = GetTrolleyPoint();
        }

        // присоединить троллейбус к проводам
        private void ConnectTrolley()
        {
            lock (trolleybus)
            {
                // создаем траекторию от места водителя к задней части автобуса
                OneWayTrace trace = new OneWayTrace(this.Point, new Point(this.Point.X + 150, this.Point.Y + 50));
                // пока траектория не пройдена, получаем следующую точку
                while (!trace.IsFinished)
                {
                    this.Point = trace.NextPoint(this.Point);
                    Task.Delay(200).Wait();
                }
                // создаем траекторию для возвращения на место водителя
                trace = new OneWayTrace(this.Point, GetTrolleyPoint());
                // пока траектория не пройдена, получаем следующую точку
                while (!trace.IsFinished)
                {
                    this.Point = trace.NextPoint(this.Point);
                    Task.Delay(200).Wait();
                }
                // отмечаем, что автобус присоединен
                trolleybus.Connect();
            }
            // снимаем блок
            IsLocked = false;
            elemAction = null;
        }

        protected override void CheckEvents()
        {
            if (!IsLocked && trolleybus.IsDisconnected)
            {
                IsLocked = true;
                Notification($"Водитель {name} пошёл присоединить троллейбус номер {trolleybus.Number} к напряжению");
                elemAction = ConnectTrolley;
            }
            else
            {
                this.Point = GetTrolleyPoint();
            }
        }
    }
}
