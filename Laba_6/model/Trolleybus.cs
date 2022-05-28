using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba_5.model
{
    public class Trolleybus : ModelElement
    {
        // троллейбус сломан
        private bool isBroken;
        // троллейбус отсоединен от напряжения
        private bool isDisconnected;
        // назначена аварийная служба
        private bool emergencyAppointed;
        // номер троллейбуса
        private int number;
        private TrolleyTrace trace;

        public bool IsBroken { get { return isBroken; } }
        public bool IsDisconnected { get { return isDisconnected; } }
        public bool EmergencyAppointed { get { return emergencyAppointed; } set { emergencyAppointed = value; } }
        public int Number { get { return number; } }

        public Trolleybus(int number, Action<string> notification, Point point, TrolleyTrace trace) : base(notification)
        {
            this.Point = point;
            isBroken = false;
            isDisconnected = false;
            this.number = number;
            this.trace = trace;
        }

        // генерация поломки
        private void RandomBreak(Random random)
        {
            if (!IsLocked && random.Next(0, 10) < 1)
            {
                isBroken = true;
                IsLocked = true;
                Notification($"Троллейбус номер {number} сломан");
            }
        }

        // генерация отключения от напряжения
        private void RandomDisconnect(Random random)
        {
            if (!IsLocked && random.Next(0, 10) < 1)
            {
                isDisconnected = true;
                IsLocked = true;
                Notification($"Троллейбус номер {number} отсоединен от напряжения");
            }
        }

        // починить троллейбус
        public void Repair()
        {
            isBroken = false;
            IsLocked = false;
            emergencyAppointed = false;
            Notification($"Троллейбус номер {number} отремонтирован");
        }

        // присоединить к напряжению
        public void Connect()
        {
            isDisconnected = false;
            IsLocked = false;
            Notification($"Троллейбус номер {number} подключен к напряжению");
        }
        public void Move()
        {
            this.Point = trace.NextPoint(this.Point);
        }

        public override void Start()
        {
            Random random = new Random();
            while (!IsStopped)
            {
                Task.Delay(200).Wait();
                if (!IsLocked && !IsBroken && !IsDisconnected)
                    RandomBreak(random);
                if (!IsLocked && !IsBroken && !IsDisconnected)
                    RandomDisconnect(random);
                if (!IsLocked && !IsBroken && !IsDisconnected)
                    Move();
            }
        }
    }
}
