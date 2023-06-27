using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20230626_Test01_Okumura.src
{
    public static class Variables
    {
        #region Games
        /// <summary>
        /// ゲーム中かどうか
        /// </summary>
        public static bool InGame = false;
        public static bool Goal = false;
        #endregion


        #region Player
        /// <summary>
        /// シューターの蹴る方向
        /// シューターから見て
        /// 0: 右
        /// 1: 真ん中
        /// 2: 左
        /// </summary>
        public static int PlayerKickAmount { get; set; } = 1;
        /// <summary>
        /// プレイヤーが蹴れるキックの残り回数
        /// </summary>
        public static int KickAmount = 1;
        #endregion

        #region Keaper
        /// <summary>
        /// キーパーの守る方向
        /// キーパーから見て
        /// 0: 左
        /// 1: 真ん中
        /// 2: 右
        /// </summary>
        public static int KeaperBlockAmount { get; set; } = 1;
        #endregion
    }
}
