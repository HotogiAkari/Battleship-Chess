using UnityEngine;

public class HexTile : MonoBehaviour
{
    // 这个六边形格子的逻辑轴坐标 (q, r)
    public Vector2Int AxialCoordinates { get; private set; }

    // 可以在这里添加其他格子相关的属性，例如：
    // public bool IsOccupied { get; set; } = false;
    // public GameObject OccupyingUnit { get; set; } = null;
    // public int MovementCost { get; private set; } = 1;

    /// <summary>
    /// 初始化六边形格子的逻辑坐标。
    /// </summary>
    /// <param name="q">六边形的 Q 坐标。</param>
    /// <param name="r">六边形的 R 坐标。</param>
    public void SetCoordinates(int q, int r)
    {
        AxialCoordinates = new Vector2Int(q, r);
        // 更新 GameObject 的名称，使其在 Hierarchy 中更易于识别和调试
        gameObject.name = $"Hex_{q},{r}";
    }
}