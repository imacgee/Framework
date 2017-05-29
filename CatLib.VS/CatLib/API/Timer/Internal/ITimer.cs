﻿/*
 * This file is part of the CatLib package.
 *
 * (c) Yu Bin <support@catlib.io>
 *
 * For the full copyright and license information, please view the LICENSE
 * file that was distributed with this source code.
 *
 * Document: http://catlib.io/
 */

using System;

namespace CatLib.API.Timer
{
    /// <summary>
    /// 计时器
    /// </summary>
    public interface ITimer
    {
        /// <summary>
        /// 计时器组
        /// </summary>
        ITimerGroup Group { get; }

        /// <summary>
        /// 当前逻辑帧后，延迟指定时间后执行
        /// </summary>
        /// <param name="time">延迟时间(秒)</param>
        void Delay(float time);

        /// <summary>
        /// 当前逻辑帧后 ，延迟指定帧数帧后执行
        /// (如: 为0则表示当前逻辑帧后的下一帧执行)
        /// </summary>
        /// <param name="frame">帧数</param>
        void DelayFrame(int frame);

        /// <summary>
        /// 当前逻辑帧后 ，循环执行指定时间
        /// </summary>
        /// <param name="time">循环时间(秒)</param>
        void Loop(float time);

        /// <summary>
        /// 当前逻辑帧后 ，循环执行，直到函数返回false
        /// </summary>
        /// <param name="loopFunc">循环状态函数</param>
        void Loop(Func<bool> loopFunc);

        /// <summary>
        /// 当前逻辑帧后 ，循环执行指定帧数
        /// </summary>
        /// <param name="frame">循环的帧数</param>
        void LoopFrame(int frame);
    }
}