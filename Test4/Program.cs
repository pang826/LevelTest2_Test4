using Microsoft.VisualBasic;

namespace Test4
{
    //    맵 이동 만들기
    //1. 플레이어는 여러 장소 중 한 곳에 위치한다.
    //2. 플레이어는 마을에 위치하고 게임을 시작한다.
    //3. 플레이어는 현재 있는 장소에서 연결된 장소로만 이동이 가능하다.
    //4. 게임에는 현재 장소, 이동 경로(스택 예상), 이동이 가능한 장소 목록이 표시된다.
    //5. 장소 목록에서 선택하는 경우 해당 장소로 이동하여 현재 장소가 된다.
    //6. 뒤로가기를 선택 하는 경우 이동했던 경로를 되돌아간다.

    internal class Program
    {
        enum Map { 마을, 길드, 성, 상점, 묘지, 숲, 초원, 바다}
        public class Way
        {
            public string curMap { get; set; }

            public Way()
            {

            }

            public void CurLocation(int map)
            {

            }
            public void Togo()
            {

            }
        }
        static void Main(string[] args)
        {
            List<string>[] way = new List<string>[8];
            Way wayTogo = new Way();

            for (int i = 0; i < way.Length; i++)
            {
                way[i] = new List<string>();
            }
            //0 = 마을 / 1 = 길드 / 2 = 성 / 3 = 상점 / 4 = 묘지 / 5 = 숲 / 6 = 초원 / 7 = 바다
            
            way[0].Add("성");
            way[0].Add("묘지");

            way[1].Add("성");
            way[1].Add("상점");
            way[1].Add("숲");

            way[2].Add("마을");
            way[2].Add("길드");
            way[2].Add("숲");
            way[2].Add("초원");
            way[2].Add("묘지");

            way[3].Add("길드");
            way[3].Add("숲");
            way[3].Add("바다");

            way[4].Add("마을");
            way[4].Add("성");
            way[4].Add("초원");
            way[4].Add("바다");

            way[5].Add("길드");
            way[5].Add("성");
            way[5].Add("상점");
            way[5].Add("초원");

            way[6].Add("성");
            way[6].Add("묘지");
            way[6].Add("숲");
            way[6].Add("바다");

            way[7].Add("초원");
            way[7].Add("상점");
            way[7].Add("묘지");

            if()
            while (true)
            {
                //Console.Clear();
                Console.WriteLine("====== 맵 이동 ======");
                Console.WriteLine();
               // Console.WriteLine($"현재장소 {}");
               // Console.WriteLine($"이동경로 {}");
                Console.WriteLine();
                Console.WriteLine(way[0].Contains());


                Console.Write("이동할 장소를 선택하세요 : ");
                Console.ReadLine();
            }
        }
    }
}
