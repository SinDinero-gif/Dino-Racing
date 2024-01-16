using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FuncionMenu : MonoBehaviour
{
  public GameObject optionsWindow, menuPrincipal;
  
  void Start(){

    optionsWindow.SetActive(false);
    menuPrincipal.SetActive(true);
  }


   public void Salir(){
    //Sale del juego
     Application.Quit();
     Debug.Log("Saliste de la aplicación");
   }

   public void Empezar1(string Unjugador){
    //Activa el modo 1 Jugador
     SceneManager.LoadScene(Unjugador);

   }

   public void Empezar2(string DosJugadores){
    //Activa el modo 2 Jugadores
     SceneManager.LoadScene(DosJugadores);
   }

  //Activa la ventana de Opciones
   public void Opciones(){
    
     optionsWindow.SetActive(true);
     menuPrincipal.SetActive(false);
   }

  //Desactiva la ventana de Opciones
   public void Volver(){
    
    optionsWindow.SetActive(false);
    menuPrincipal.SetActive(true);
   }

   public void Menu(string Menu){
    //Vuelve al menu principal
    SceneManager.LoadScene(Menu);
   }





}
