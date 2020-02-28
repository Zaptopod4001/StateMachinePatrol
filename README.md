# Finite State Machine demo (Unity 2018.4 / C#)

![State machine demo](/doc/fsm_patrol.png)


## What is it?

* A minimalistic FSM implementation with interface based contract to for states and Dictionary to store runtime states 


## Example implementation

* I've added an example implementation where FSM is used for an agent with a patrol, idle and a chase behavior

* Agent will roam randomly and stops occasionally

* If agent sees the player it will transition to a chase state

* If agent catches the player it will stop

* Note: implementation is not in any way optimized, it is exists only to demonstrate how this particular FSM could be used.


## Classes

### FSM
The state machine class that manages updating current state and state transitions.

### IState
Interface that defines methods each state should have. Note: each state can have its own constructor, where it can pass any reference it needs.


## Demo / implementation classes

### FSMTest
Owner class that uses FSM to manage its behaviors. In this case it is a patrolling sprite character.

### WanderState
The default state of this implementation. Makes agent character walk and idle.

### ChaseState
The other state of this implementation. Makes agent chase player character. If player is lost from sight, it returns back to wander state.



## About
I created this while learning about finite state machines. I no longer use this kind of state machine.


## Copyright 
Created by Sami S. use of any kind without a written permission from the author is not allowed. But feel free to take a look.
