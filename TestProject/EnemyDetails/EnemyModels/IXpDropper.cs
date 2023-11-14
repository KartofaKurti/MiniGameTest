using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject.EnemyDetails.EnemyModels
{
    public interface IXpDropper
    {
        public void GiveXp(Character character, Enemy enemy);
    }
}
