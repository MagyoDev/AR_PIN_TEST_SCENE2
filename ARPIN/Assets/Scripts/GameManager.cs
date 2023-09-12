using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class GameManager : MonoBehaviour
{
    // Eventos que serão acionados para notificar outras partes do código sobre mudanças no jogo
    public event Action OnMainMenu; // Evento para ativar o menu principal
    public event Action OnItemsMenu; // Evento para ativar o menu de itens
    public event Action OnHeaderMenu; // Evento para ativar o menu de header
    public event Action OnCodeMenu; // Evento para ativar o menu de Código
    public event Action OnScene2CodeMenu; // Evento para ativar o menu de Código na Scene 2
    public event Action OnARPosition; // Evento para ativar a posição de realidade aumentada (AR)
    
    // Instância estática do GameManager, permitindo acesso global a partir de outras classes
    public static GameManager instance;

    private void Awake()
    {
        // Verifica se já existe uma instância do GameManager, de forma que só exista uma em todo o jogo
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
        }
        else
        {
            instance = this;
        }
    }

    // Start é chamado antes do primeiro quadro (frame) ser atualizado
    void Start()
    {
        // Inicia o jogo com o menu principal
        MainMenu();
    }

    // Método para ativar o menu principal e chamar o evento associado
    public void MainMenu()
    {
        OnMainMenu?.Invoke();
        Debug.Log("Menu Principal Ativado");
    }

    // Método para ativar o menu de itens e chamar o evento associado
    public void ItemsMenu()
    {
        OnItemsMenu?.Invoke();
        Debug.Log("Menu de Itens Ativado");
    }

    // Método para ativar a posição de realidade aumentada (AR) e chamar o evento associado
    public void ARPosition()
    {
        OnARPosition?.Invoke();
        Debug.Log("Posição de AR Ativada");
    }

    // Método para ativar o menu de header e chamar o evento associado
    public void HeaderMenu()
    { 
        OnHeaderMenu?.Invoke();
        Debug.Log("Header");
    }

    // Método para ativar o menu de código e chamar o evento associado
    public void CodeMenu()
    {
        OnCodeMenu?.Invoke();
        Debug.Log("Code");
    }

    // Método para ativar o menu de código na scene2 e chamar o evento associado
    public void Scene2CodeMenu()
    {
        OnCodeMenu?.Invoke();
        Debug.Log("Scene2Code");
    }


    // Método para fechar o aplicativo
    public void CloseAPP()
    {
        Application.Quit();
    }
}