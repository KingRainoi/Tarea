using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jamesapp
{
    class Program
    {
        static void Main(string[] args)
        {
            string hellSchedule = "Sun 10:00-20:00\nFri 05:00-10:00\nFri 16:30-23:50\nSat 10:00-24:00\nSun 01:00-04:00\nSat 02:00-06:00\nTue 03:30-18:15\nTue 19:00-20:00\nWed 04:25-15:14\nWed 15:14-22:40\nThu 00:00-23:59\nMon 05:00-13:00\nMon 15:00-21:00";

            var listHell = hellSchedule.Split('\n');
            var sortedHellList = listHell.ToList();
            List<Tiempo> lista = new List<Tiempo>();
            List<Tiempo> Nlista = new List<Tiempo>();
            List<Tiempo> descansos = new List<Tiempo>();


            foreach (var date in sortedHellList)
            {
                Tiempo temp = new Tiempo();


                var list = date.Split(' ');
                temp.Day = list[0];
                var tiempos = list[1].Split('-');
                var tiempos2 = tiempos[0].Split(':');
                var tiempos3 = tiempos[1].Split(':');

                temp.Day = list[0];
                temp.InicioH = tiempos2[0];
                temp.InicioM = tiempos2[1];
                temp.FinH = tiempos3[0];
                temp.FinM = tiempos3[1];

                lista.Add(temp);
            }

            foreach (var record in lista)
            {
                if (record.Day == "Sun")
                {
                    Nlista.Add(record);
                }
            }

            foreach (var record in lista)
            {
                if (record.Day == "Mon")
                {
                    Nlista.Add(record);
                }
            }

            foreach (var record in lista)
            {
                if (record.Day == "Tue")
                {
                    Nlista.Add(record);
                }
            }

            foreach (var record in lista)
            {
                if (record.Day == "Wed")
                {
                    Nlista.Add(record);
                }
            }

            foreach (var record in lista)
            {
                if (record.Day == "Thu")
                {
                    Nlista.Add(record);
                }
            }

            foreach (var record in lista)
            {
                if (record.Day == "Fri")
                {
                    Nlista.Add(record);
                }
            }

            foreach (var record in lista)
            {
                if (record.Day == "Sat")
                {
                    Nlista.Add(record);
                }
            }

            foreach (var t in Nlista)
            {
                if (t.Day == "Sun")
                {
                    foreach (var x in Nlista)
                    {
                        if (x.Day == "Sun")
                        {
                            if (Convert.ToInt32(t.InicioH) > Convert.ToInt32(x.InicioH))
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(t.FinH) - Convert.ToInt32(x.InicioH);
                                var timeM = Convert.ToInt32(t.FinM) - Convert.ToInt32(x.InicioM);

                                rest.Day = t.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                            else
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(x.FinH) - Convert.ToInt32(t.InicioH);
                                var timeM = Convert.ToInt32(x.FinM) - Convert.ToInt32(t.InicioM);

                                rest.Day = x.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                        }
                        if (x.Day == "Mon")
                        {
                            if (Convert.ToInt32(t.InicioH) > Convert.ToInt32(x.InicioH))
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(t.FinH) - Convert.ToInt32(x.InicioH);
                                var timeM = Convert.ToInt32(t.FinM) - Convert.ToInt32(x.InicioM);

                                rest.Day = t.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                            else
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(x.FinH) - Convert.ToInt32(t.InicioH);
                                var timeM = Convert.ToInt32(x.FinM) - Convert.ToInt32(t.InicioM);

                                rest.Day = x.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                        }
                        if (x.Day == "Tue")
                        {
                            if (Convert.ToInt32(t.InicioH) > Convert.ToInt32(x.InicioH))
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(t.FinH) - Convert.ToInt32(x.InicioH);
                                var timeM = Convert.ToInt32(t.FinM) - Convert.ToInt32(x.InicioM);

                                rest.Day = t.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                            else
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(x.FinH) - Convert.ToInt32(t.InicioH);
                                var timeM = Convert.ToInt32(x.FinM) - Convert.ToInt32(t.InicioM);

                                rest.Day = x.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                        }
                        if (x.Day == "Wed")
                        {
                            if (Convert.ToInt32(t.InicioH) > Convert.ToInt32(x.InicioH))
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(t.FinH) - Convert.ToInt32(x.InicioH);
                                var timeM = Convert.ToInt32(t.FinM) - Convert.ToInt32(x.InicioM);

                                rest.Day = t.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                            else
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(x.FinH) - Convert.ToInt32(t.InicioH);
                                var timeM = Convert.ToInt32(x.FinM) - Convert.ToInt32(t.InicioM);

                                rest.Day = x.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                        }
                        if (x.Day == "Thu")
                        {
                            if (Convert.ToInt32(t.InicioH) > Convert.ToInt32(x.InicioH))
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(t.FinH) - Convert.ToInt32(x.InicioH);
                                var timeM = Convert.ToInt32(t.FinM) - Convert.ToInt32(x.InicioM);

                                rest.Day = t.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                            else
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(x.FinH) - Convert.ToInt32(t.InicioH);
                                var timeM = Convert.ToInt32(x.FinM) - Convert.ToInt32(t.InicioM);

                                rest.Day = x.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                        }
                        if (x.Day == "Fri")
                        {
                            if (Convert.ToInt32(t.InicioH) > Convert.ToInt32(x.InicioH))
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(t.FinH) - Convert.ToInt32(x.InicioH);
                                var timeM = Convert.ToInt32(t.FinM) - Convert.ToInt32(x.InicioM);

                                rest.Day = t.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                            else
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(x.FinH) - Convert.ToInt32(t.InicioH);
                                var timeM = Convert.ToInt32(x.FinM) - Convert.ToInt32(t.InicioM);

                                rest.Day = x.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                        }
                        if (x.Day == "Sat")
                        {
                            if (Convert.ToInt32(t.InicioH) > Convert.ToInt32(x.InicioH))
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(t.FinH) - Convert.ToInt32(x.InicioH);
                                var timeM = Convert.ToInt32(t.FinM) - Convert.ToInt32(x.InicioM);

                                rest.Day = t.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                            else
                            {
                                Tiempo rest = new Tiempo();

                                var timeH = Convert.ToInt32(x.FinH) - Convert.ToInt32(t.InicioH);
                                var timeM = Convert.ToInt32(x.FinM) - Convert.ToInt32(t.InicioM);

                                rest.Day = x.Day;
                                rest.InicioH = Convert.ToString(timeH);
                                rest.InicioM = Convert.ToString(timeM);
                                descansos.Add(rest);
                            }
                        }

                        Console.WriteLine(descansos);
                        Console.ReadLine();
                    }
                }
            }
        }
    }
}
