using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : BaseUnitController
{
    // ---------- 定数宣言 ----------
    // ---------- プレハブ ----------
    // ---------- ゲームオブジェクト参照変数宣言 ----------
    [SerializeField] private Animator _animator; // キャラにアタッチされるアニメーターへの参照
    // ---------- プロパティ ----------
    // ---------- クラス変数宣言 ----------
    // ---------- インスタンス変数宣言 ----------
    private AnimatorStateInfo _currentBaseState;	// アニメーターの現在の状態の参照
    // ---------- コンストラクタ・デストラクタ ----------
    // ---------- Unity組込関数 ----------
    // ---------- Public関数 ----------
    // ---------- Protected関数 ----------
    // ---------- Private関数 ----------

    // 初期化
    protected override void Initialize()
    {
        return;
    }
}