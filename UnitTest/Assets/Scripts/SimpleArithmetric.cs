using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// シンプルな演算クラス
/// </summary>
public class SimpleArithmetric<T>
{
    /// <summary>
    /// 値１
    /// </summary>
    private T ValueA;

    /// <summary>
    /// 値２
    /// </summary>
    private T ValueB;

    /// <summary>
    /// コンストラクタ
    /// </summary>
    /// <param name="ValueA">値１</param>
    /// <param name="ValueB">値２</param>
    public SimpleArithmetric(T ValueA, T ValueB)
    {
        this.ValueA = ValueA;
        this.ValueB = ValueB;
    }

    /// <summary>
    /// 加算
    /// </summary>
    /// <returns>加算結果</returns>
    public T Add()
    {
        return ValueA + ValueB;
    }

    /// <summary>
    /// 減算
    /// </summary>
    /// <returns>減算結果</returns>
    public T Sub()
    {
        return ValueA - ValueB;
    }
}
