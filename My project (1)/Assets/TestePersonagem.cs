using UnityEngine;

public class TestePersonagem : MonoBehaviour
{
    public Fada fada1;
    public Fada fada2;

    void Start()
    {
        // Inicializa valores (caso não preenchido no inspetor da Unity)
        if (fada1 != null && fada2 != null)
        {
            Debug.Log($"Mago 1: {Fada1.Nome}, N" + $"Nível: {Fada1.Nivel}, Vida: {Fada1.Vida}, Mana: {Fada1.Mana}");
            Debug.Log($"Mago 2: {Fada2.Nome}, Nível: {Fada2.Nivel}, Vida: {Fada2.Vida}, Mana: {Fada2.Mana}");

            Debug.Log(Fada1.CompararNivel(Fada2));
            
            
            
            
        }
        else
        {
            Debug.LogWarning("Personagens não atribuídos.");
        }
    }
}