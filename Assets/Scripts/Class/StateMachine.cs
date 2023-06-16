using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/*


MAQUINA DE ESTADO

SE CONFIGURAN CUATRO ESTADOS POSIBLES.
ESTOS SON Idle, Moving, Attacking, Dead.

LUEGO SE CREA LA CLASE StateMachine.

EL METODO SetState(State newState) SE DEDICA
A CONTROLAR EL CAMBIO DE ESTADO AL SER INVOCADO
CON EL VALOR DE UNO DE LOS ESTADOS ANTERIORES.

EL METODO EnterState(State state) SE ENCARGA
DE OBTENER EL ALGORITMO DEDICADO PARA CADA
ESTADO.

*/

public enum State
{
    Idle,
    Moving,
    Attacking,
    Dead,
    Jump
}

public class StateMachine : MonoBehaviour
{
    private State currentState;

    public void SetState(State newState)
    {
        // Salir del estado actual si es necesario

        // Cambiar al nuevo estado
        currentState = newState;

        // Entrar en el nuevo estado
        EnterState(newState);
    }

    private void EnterState(State state)
    {
        // Realizar acciones específicas al entrar en el estado
        switch (state)
        {
            case State.Idle:
               // Debug.Log("Parado");
                // Acciones específicas del estado Idle
                break;
            case State.Moving:
              Debug.Log("Camnando");
                // Acciones específicas del estado Moving
                break;
            case State.Attacking:
                // Acciones específicas del estado Attacking
                break;
            case State.Dead:
                // Acciones específicas del estado Dead
                break;
            case State.Jump:
              //  Debug.Log("Saltando");
                // Acciones específicas del estado Moving
                break;
        }
    }
}
