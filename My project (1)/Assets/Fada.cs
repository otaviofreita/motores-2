
using UnityEngine;

public class Fada : Personagem
{
    [SerializeField] private float mana;
    [SerializeField] private string habilidadeEspecial = "Pó de Fada";

    public float Mana { get => mana; set => mana = value; }
    public string HabilidadeEspecial { get => habilidadeEspecial; }
}