using System;

public class River
{

        private string name;
        public string Name
     {
        get { return this.name; }
        set { this.name = value; }
    }

    private double plosh;
    public double Plosh
    {
      get {return this.plosh;}
      set {this.plosh=Value;}
    }

    private double prot;
    public double Prot
    {
        get { return this.prot; }
        set { this.prot = value; }
    }

    public River()
    {
        this.Name = "";
        this.Plosh = "";
        this.Prot = "";
    }
    public River(string name, double plosh, double prot)
    {
        this.Name = name;
        this.Plosh = plosh;
        this.Prot = prot;
    }

    public virtual string GetTextPrint()
    {
        return "Название " + this.Name + " Площадь " + this.Plosh + " Протяженность " + this.Prot;
    }


}

