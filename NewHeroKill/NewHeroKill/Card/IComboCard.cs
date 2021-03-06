﻿using NewHeroKill.Player;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewHeroKill.Card
{
    /// <summary>
    /// 组合牌接口
    /// </summary>
    public interface IComboCard
    {
        /// <summary>
        /// 获取真实牌
        /// </summary>
        /// <returns></returns>
        List<AbstractCard> GetRealCards();
        
        /// <summary>
        /// 获取该虚拟牌的替代值
        /// </summary>
        /// <returns></returns>
        int GetCardType();

        /// <summary>
        /// 主动使用
        /// </summary>
        /// <param name="p"></param>
        /// <param name="toP"></param>
        void Use(AbstractPlayer p, AbstractPlayer toP);
    }
}
