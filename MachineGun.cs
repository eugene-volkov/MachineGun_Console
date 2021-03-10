using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MachineGun_Console
{
    class MachineGun
    {
        //public const int MAGAZINE_SIZE = 16;
        public int MagazineSize { get; private set; } = 16;

        private int bullets = 0;
        //private int bulletsLoaded = 0;

        //public int GetBulletsLoaded() { return bulletsLoaded; }

        //public int BulletsLoaded
        //{ 
        //    get { return bulletsLoaded; }
        //    set { bulletsLoaded = value; }
        //}

        public int BulletsLoaded { get; private set; }

        public MachineGun(int bullets, int magazineSize, bool loaded)
        {
            this.bullets = bullets;
            MagazineSize = magazineSize;
            if (!loaded) Reload();
        }

        public bool IsEmpty() { return BulletsLoaded == 0; }

        // Create propery Bullets instead methods GetBullets, SetBullets
        public int Bullets 
        {
            get { return bullets; }
            set 
            {
                if (value > 0)
                    bullets = value;
                Reload();
            }
        }

        //public int GetBullets() { return bullets; }

        //public void SetBullets(int numberOfBullets)
        //{
        //    if (numberOfBullets > 0)
        //        bullets = numberOfBullets;
        //    Reload();
        //}

        public void Reload()
        {
            if (bullets > MagazineSize)
                BulletsLoaded = MagazineSize;
            else
                BulletsLoaded = bullets;
        }

        public bool Shoot()
        {
            if (BulletsLoaded == 0) return false;
            BulletsLoaded--;
            bullets--;
            return true;
        }
    }
}
