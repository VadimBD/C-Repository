using Magician_s_combat;
using Magician_s_combat.Interfaces;
using System.Linq;

internal class Program
{
    private static void Main(string[] args)
    {
        var wizardsInit = WizardsInitialization();
        Console.WriteLine("Player1 enter name: ");
        var player1 = Console.ReadLine();
        Console.WriteLine("Choose your wizard: ");
        foreach( var wizard in wizardsInit.Keys)
        {
            Console.WriteLine(wizard);
        }
        IWizard wizard1=null;
        do
        {
            var wizardKey = Console.ReadLine();
            if(wizardsInit.ContainsKey(wizardKey))
            {
                wizard1 = wizardsInit[wizardKey](player1);
            }
            else
            {
                Console.WriteLine("Incorrect wizard name. Enter the wizard's name from the list please: ");
            }
        } while (wizard1==null);
        
        Console.WriteLine("Player2 enter name : ");
        var player2 = Console.ReadLine();
        Console.WriteLine("Choose your wizard: ");
        foreach (var wizard in wizardsInit.Keys)
        {
            Console.WriteLine(wizard);
        }
        IWizard wizard2 = null;
        do
        {
            var wizardKey = Console.ReadLine();
            if (wizardsInit.ContainsKey(wizardKey))
            {
                wizard2 = wizardsInit[wizardKey](player2);
            }
            else
            {
                Console.WriteLine("Incorrect wizard name. Enter wizard's name from the list please: ");
            }
        } while (wizard2 == null);

        wizard1.GetHitEvent += Wizard_GetHitEventHandler;
        wizard2.GetHitEvent += Wizard_GetHitEventHandler;


        while (wizard1.Alive && wizard2.Alive) 
        {
           var spell=RequestUserSpell(wizard1);
           if(wizard2 is IDamaged w2)
            {
                w2.GetHit(spell);
            }
            if (wizard2.Alive)
            {
                spell = RequestUserSpell(wizard2);
                if (wizard1 is IDamaged w1)
                {
                    w1.GetHit(spell);
                }
            }
        }
        var winer = wizard1.Alive ? wizard1.Name : wizard2.Name;
        Console.WriteLine($"{winer} win!");
        Console.WriteLine("Game Over!");
    }

    private static void Wizard_GetHitEventHandler(object sender, GetHitArgs args)
    {
        if (args.Alive)
        {
            Console.WriteLine($"{((IWizard)sender).Name} received damage {args.Damage} but survived");
        }
        else 
        {
            Console.WriteLine($"{((IWizard)sender).Name} received damage {args.Damage}.And died a heroic death.");
        }
    }
 
    public static Dictionary<string, Func<string,IWizard>> WizardsInitialization()
    {
        var result=new Dictionary<string,Func<string, IWizard>>();
        result.Add("FireWizard", (name) => new FireWizard(name));
        result.Add("WaterWizard", (name) => new WaterWizard(name));
        result.Add("EarthWizard", (name) => new EarthWizard(name));
        result.Add("AirWizard", (name) => new AirWizard(name));

        return result;
    }
    public  static void DisplaySpells(IWizard wizard)
    {
        foreach(var spell in wizard.Spells.Keys)  
        { 
            Console.WriteLine(spell);
        }
    }
    public static ISpell RequestUserSpell(IWizard wizard)
    {
        Console.WriteLine($" {wizard.Name} choose a spell {wizard.Skin}:");
        DisplaySpells(wizard);
        ISpell spell=null;
        do
        {
            var key=Console.ReadLine();
            if(wizard.Spells.ContainsKey(key))
            {
                spell= wizard.Spells[key];
            }
            else
            {
                Console.WriteLine("Incorrect spell name. Enter spell name from the list please: ");
            }
        } while (spell==null);
        return spell;
    }


}