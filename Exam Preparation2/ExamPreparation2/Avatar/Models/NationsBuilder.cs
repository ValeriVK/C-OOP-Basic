using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Avatar.Models.Benders;
using Avatar.Models.Factories;
using Avatar.Models.Monuments;

namespace Avatar.Models
{
    public class NationsBuilder
    {
        private readonly List<Bender>  airNation;
        private readonly List<Bender> waterNation;
        private readonly List<Bender> fireNation;
        private readonly List<Bender> earthNation;
        private readonly List<Monument> airNationMonuments;
        private readonly List<Monument> waterNationMonuments;
        private readonly List<Monument> fireNationMonuments;
        private readonly List<Monument> earthNationMonuments;
        private readonly List<string> wars;

        public NationsBuilder()
        {
            this.airNation = new List<Bender>();
            this.waterNation = new List<Bender>();
            this.fireNation = new List<Bender>();
            this.earthNation = new List<Bender>();
            this.airNationMonuments = new List<Monument>();
            this.waterNationMonuments = new List<Monument>();
            this.fireNationMonuments = new List<Monument>();
            this.earthNationMonuments = new List<Monument>();
            this.wars = new List<string>();
        }

        //public List<Bender> AirNation
        //{
        //    get { return this.airNation; }
        //}

        //public List<Bender> WaterNation
        //{
        //    get { return this.waterNation; }
        //}

        //public List<Bender> FireNation
        //{
        //    get { return this.fireNation; }
        //}

        //public List<Bender> EarthNation
        //{
        //    get { return this.earthNation; }
        //}

        //public List<Monument> AirNationMonuments
        //{
        //    get { return this.airNationMonuments; }
        //}

        //public List<Monument> WaterNationMonuments
        //{
        //    get { return this.waterNationMonuments; }
        //}

        //public List<Monument> FireNationMonuments
        //{
        //    get { return this.fireNationMonuments; }
        //}

        //public List<Monument> EarthNationMonuments
        //{
        //    get { return this.earthNationMonuments; }
        //}

        //public List<string> Wars
        //{
        //    get { return this.wars; }
        //}

        public void AssignBender(List<string> benderArgs)
        {
            var benderType = benderArgs[0];
            var bender = BenderFactory.GetBender(benderArgs);

            switch (benderType)
            {
                case "Air":
                {
                    this.airNation.Add(bender);
                }
                    break;
                case "Water":
                {
                    this.waterNation.Add(bender);
                }
                    break;
                case "Fire":
                {
                    this.fireNation.Add(bender);
                }
                    break;
                case "Earth":
                {
                    this.earthNation.Add(bender);
                }
                    break;
            }
        }

        public void AssignMonument(List<string> monumentArgs)
        {
            var monumentType = monumentArgs[0];
            var monument = MonumentFactory.GetMonument(monumentArgs);
            switch (monumentType)
            {
                case "Air":
                {
                    this.airNationMonuments.Add(monument);
                }
                    break;
                case "Water":
                {
                    this.waterNationMonuments.Add(monument);
                }
                    break;
                case "Fire":
                {
                    this.fireNationMonuments.Add(monument);
                }
                    break;
                case "Earth":
                {
                    this.earthNationMonuments.Add(monument);
                }
                    break;
            }
        }

        public string GetStatus(string nationsType)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"{nationsType} Nation");
            sb.Append("Benders:");
            switch (nationsType)
            {
                case "Air":
                {
                    if (this.airNation.Count > 0)
                    {
                        sb.AppendLine();
                        this.airNation.ForEach(b => sb.AppendLine(b.ToString()));
                    }
                    else
                    {
                        sb.Append(" None");
                        sb.Append(Environment.NewLine);
                    }
                    if (this.airNationMonuments.Count == 0)
                    {
                        sb.AppendLine("Monuments: None");
                    }
                    else
                    {
                        sb.AppendLine("Monuments:");
                        this.airNationMonuments.ForEach(m => sb.AppendLine(m.ToString()));
                    }
                }
                    break;
                case "Water":
                {
                    if (this.waterNation.Count > 0)
                    {
                        sb.AppendLine();
                        this.waterNation.ForEach(b => sb.AppendLine(b.ToString()));
                    }
                    else
                    {
                        sb.Append(" None");
                        sb.Append(Environment.NewLine);
                    }

                    if (this.waterNationMonuments.Count == 0)
                    {
                        sb.AppendLine("Monuments: None");
                    }
                    else
                    {
                        sb.AppendLine("Monuments:");
                        this.waterNationMonuments.ForEach(m => sb.AppendLine(m.ToString()));
                    }
                }
                    break;
                case "Fire":
                {
                    if (this.fireNation.Count > 0)
                    {
                        sb.AppendLine();
                        this.fireNation.ForEach(b => sb.AppendLine(b.ToString()));
                    }
                    else
                    {
                        sb.Append(" None");
                        sb.Append(Environment.NewLine);
                    }

                    if (this.fireNationMonuments.Count == 0)
                    {
                        sb.AppendLine("Monuments: None");
                    }
                    else
                    {
                        sb.AppendLine("Monuments:");
                        this.fireNationMonuments.ForEach(m => sb.AppendLine(m.ToString()));
                    }
                }
                    break;
                case "Earth":
                {
                    if (this.earthNation.Count > 0)
                    {
                        sb.AppendLine();
                        this.earthNation.ForEach(b => sb.AppendLine(b.ToString()));
                    }
                    else
                    {
                        sb.Append(" None");
                        sb.Append(Environment.NewLine);
                    }

                    if (this.earthNationMonuments.Count == 0)
                    {
                        sb.AppendLine("Monuments: None");
                    }
                    else
                    {
                        sb.AppendLine("Monuments:");
                        this.earthNationMonuments.ForEach(m => sb.AppendLine(m.ToString()));
                    }
                }
                    break;
            }
            return sb.ToString().Trim();
        }

        public void IssueWar(string nationsType)
        {
            this.wars.Add(nationsType);
            var airNationPower = this.airNation.Sum(b => b.TotalPower);
            var airMonumentsPower = this.airNationMonuments.Sum(m => m.Affinity);
            var tap = airNationPower + airNationPower * airMonumentsPower / 100;

            var waterNationPower = this.waterNation.Sum(b => b.TotalPower);
            var waterMonumentsPower = this.waterNationMonuments.Sum(m => m.Affinity);
            var twp = waterNationPower + waterNationPower * waterMonumentsPower / 100;

            var fireNationPower = this.fireNation.Sum(b => b.TotalPower);
            var fireMonumentsPower = this.fireNationMonuments.Sum(m => m.Affinity);
            var tfp = fireNationPower + fireNationPower * fireMonumentsPower / 100;

            var earthNationPower = this.earthNation.Sum(b => b.TotalPower);
            var earthMonumentsPower = this.earthNationMonuments.Sum(m => m.Affinity);
            var tep = earthNationPower + earthNationPower * earthMonumentsPower / 100;

            if (tap > twp && tap > tfp && tap > tep)
            {
                this.waterNation.Clear();
                this.waterNationMonuments.Clear();
                this.fireNation.Clear();
                this.fireNationMonuments.Clear();
                this.earthNation.Clear();
                this.earthNationMonuments.Clear();
            }
            else if (tap < twp && twp > tfp && twp > tep)
            {
                this.airNation.Clear();
                this.airNationMonuments.Clear();
                this.fireNation.Clear();
                this.fireNationMonuments.Clear();
                this.earthNation.Clear();
                this.earthNationMonuments.Clear();
            }
            else if (tfp > tap && tfp > twp && tfp > tep)
            {
                this.airNation.Clear();
                this.airNationMonuments.Clear();
                this.waterNation.Clear();
                this.waterNationMonuments.Clear();
                this.earthNation.Clear();
                this.earthNationMonuments.Clear();
            }
            else if (tep > tap && tep > twp && tep > tfp)
            {
                this.airNation.Clear();
                this.airNationMonuments.Clear();
                this.waterNation.Clear();
                this.waterNationMonuments.Clear();
                this.fireNation.Clear();
                this.fireNationMonuments.Clear();
            }
        }

        public string GetWarsRecord()
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 1; i <= this.wars.Count; i++)
            {
                sb.AppendLine($"War {i} issued by {this.wars[i - 1]}");
            }
            return sb.ToString().Trim();
        }
    }
}