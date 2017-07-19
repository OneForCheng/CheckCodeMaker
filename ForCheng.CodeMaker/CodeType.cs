using System;

namespace ForCheng.CodeMaker
{
    /// <summary>
    /// ��֤������
    /// </summary>
    [Flags]
    public enum CodeType
    {
        /// <summary>
        /// ��
        /// </summary>
        None = 0,
        /// <summary>
        /// ����
        /// </summary>
        Number = 1,
        /// <summary>
        /// Сд��ĸ
        /// </summary>
        LowerChar = 2,
        /// <summary>
        /// ��д��ĸ
        /// </summary>
        UpperChar = 4,
        /// <summary>
        /// ���ֺ���ĸ
        /// </summary>
        All = 7,
    }
}