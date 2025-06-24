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
            Debug.Log($"Fada 1: {fada1.Nome}, N" + $"Nível: {fada1.Nivel}, Vida: {fada1.Vida}, Mana: {fada1.Mana}");
            Debug.Log($"Fada 2: {fada2.Nome}, Nível: {fada2.Nivel}, Vida: {fada2.Vida}, Mana: {fada2.Mana}");

            Debug.Log(fada1.CompararNivel(fada2));
            
            
            
            
        }
        else
        {
            Debug.LogWarning("Personagens não atribuídos.");
        }
    }
}