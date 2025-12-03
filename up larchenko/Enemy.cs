using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace up_larchenko
{
    internal class Enemy
    {
    }
}
public enum EnemyType { WEAK, NORMAL, STRONG }

public class Enemy
{
    public EnemyType Type { get; set; }
    public int HP { get; set; }
    public int MinDamage { get; set; }
    public int MaxDamage { get; set; }
    public int Gold { get; set; }
    public int Exp { get; set; }

    public static Enemy Create(EnemyType type)
    {
        Random r = new Random();
        return type switch
        {
            EnemyType.WEAK => new Enemy
            {
                Type = type,
                HP = 20,
                MinDamage = 3,
                MaxDamage = 7,
                Gold = r.Next(5, 11),
                Exp = 10
            },
            EnemyType.NORMAL => new Enemy
            {
                Type = type,
                HP = 40,
                MinDamage = 5,
                MaxDamage = 10,
                Gold = r.Next(15, 26),
                Exp = 25
            },
            EnemyType.STRONG => new Enemy
            {
                Type = type,
                HP = 60,
                MinDamage = 8,
                MaxDamage = 15,
                Gold = r.Next(30, 51),
                Exp = 50
            },
            _ => throw new ArgumentException()
        };
    }
}