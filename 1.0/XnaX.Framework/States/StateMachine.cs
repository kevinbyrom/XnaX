using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using XnaX.Framework.Messaging;


namespace XnaX.Framework
{
    public class StateMachine<TState> : IMessageReceiver, IUpdateable 
        where TState : IState
    {
        protected TState globalState;
        protected TState previousState;
        protected TState currentState;


        public StateMachine(TState currState)
        {
            this.globalState = default(TState);
            this.previousState = default(TState);
            this.currentState = default(TState);

            ChangeState(currState);
        }


        public StateMachine(TState currState, TState globalState)
        {
            this.globalState = globalState;
            this.previousState = default(TState);
            this.currentState = default(TState);

            ChangeState(currState);
        }


        /// <summary>
        /// Changes to a new state
        /// </summary>
        /// <param name="state">State to change to</param>
        
        public void ChangeState(TState state)
        {

            // Exit the current state and set to new state

            this.previousState = this.currentState;
            this.currentState = state;


            // Call state change handlers

            this.previousState.Exited();
            this.currentState.Entered();

        }


        /// <summary>
        /// Reverts back to the previous state
        /// </summary>
        
        public void RevertToPreviousState()
        {
            ChangeState(this.previousState); 
        }


        /// <summary>
        /// Updates the current and global states
        /// </summary>
        /// <param name="gameTime"></param>
        
        public void Update(GameTime gameTime)
        {
            if (this.globalState != null)
                this.globalState.Update(gameTime);
            
            if (this.currentState != null)
                this.currentState.Update(gameTime);
        }


        /// <summary>
        /// Handler for game messages 
        /// </summary>
        /// <param name="message">Message to handle</param>
        /// <param name="gameTime">Current game time</param>
        
        public virtual void ReceiveMessage(GameMessage message, GameTime gameTime)
        {
            if (this.globalState != null)
                this.globalState.ReceiveMessage(message, gameTime);
            
            if (this.currentState != null)
                this.currentState.ReceiveMessage(message, gameTime);
        }
    }
}
