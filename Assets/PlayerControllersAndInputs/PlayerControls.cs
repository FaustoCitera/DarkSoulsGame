// GENERATED AUTOMATICALLY FROM 'Assets/PlayerControls.inputactions'

using System;
using UnityEngine;
using UnityEngine.Experimental.Input;


[Serializable]
public class PlayerControls : InputActionAssetReference
{
    public PlayerControls()
    {
    }
    public PlayerControls(InputActionAsset asset)
        : base(asset)
    {
    }
    private bool m_Initialized;
    private void Initialize()
    {
        // Player Movement
        m_PlayerMovement = asset.GetActionMap("Player Movement");
        m_PlayerMovement_Movement = m_PlayerMovement.GetAction("Movement");
        m_PlayerMovement_Camara = m_PlayerMovement.GetAction("Camara");
        m_Initialized = true;
    }
    private void Uninitialize()
    {
        m_PlayerMovement = null;
        m_PlayerMovement_Movement = null;
        m_PlayerMovement_Camara = null;
        m_Initialized = false;
    }
    public void SetAsset(InputActionAsset newAsset)
    {
        if (newAsset == asset) return;
        if (m_Initialized) Uninitialize();
        asset = newAsset;
    }
    public override void MakePrivateCopyOfActions()
    {
        SetAsset(ScriptableObject.Instantiate(asset));
    }
    // Player Movement
    private InputActionMap m_PlayerMovement;
    private InputAction m_PlayerMovement_Movement;
    private InputAction m_PlayerMovement_Camara;
    public struct PlayerMovementActions
    {
        private PlayerControls m_Wrapper;
        public PlayerMovementActions(PlayerControls wrapper) { m_Wrapper = wrapper; }
        public InputAction @Movement { get { return m_Wrapper.m_PlayerMovement_Movement; } }
        public InputAction @Camara { get { return m_Wrapper.m_PlayerMovement_Camara; } }
        public InputActionMap Get() { return m_Wrapper.m_PlayerMovement; }
        public void Enable() { Get().Enable(); }
        public void Disable() { Get().Disable(); }
        public bool enabled { get { return Get().enabled; } }
        public InputActionMap Clone() { return Get().Clone(); }
        public static implicit operator InputActionMap(PlayerMovementActions set) { return set.Get(); }
    }
    public PlayerMovementActions @PlayerMovement
    {
        get
        {
            if (!m_Initialized) Initialize();
            return new PlayerMovementActions(this);
        }
    }
}
