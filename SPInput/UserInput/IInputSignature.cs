﻿using UnityEngine;

namespace com.spacepuppy.UserInput
{

    public interface IInputSignature
    {

        string Id { get; }
        int Hash { get; }
        float Precedence { get; set; }

        /// <summary>
        /// Only called by the IPlayerInputDevice on Update, if called independent of IPlayerInputDevice, state of the input signature will be inaccurate.
        /// </summary>
        void Update();

        /// <summary>
        /// Only called by the IPlayerInputDevice on FixedUpdate, if called independent of IPlayerInputDevice, state of the input signature will be inaccurate.
        /// </summary>
        void FixedUpdate();

    }

    public interface IButtonInputSignature : IInputSignature
    {
        ButtonState CurrentState { get; }

        ButtonState GetCurrentState(bool getFixedState);

        /// <summary>
        /// The button was pressed and released in a set amount of time.
        /// </summary>
        /// <param name="duration"></param>
        /// <param name="getFixedState"></param>
        /// <returns></returns>
        bool GetPressed(float duration, bool getFixedState);
    }

    public interface IAxleInputSignature : IInputSignature
    {
        float CurrentState { get; }

    }

    public interface IDualAxleInputSignature : IInputSignature
    {
        Vector2 CurrentState { get; }
    }

    public interface ICursorInputSignature : IInputSignature
    {
        Vector2 CurrentState { get; }
    }

}
