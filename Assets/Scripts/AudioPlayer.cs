using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class AudioPlayer : MonoBehaviour
{
    private AudioSource _audioSource;

    /// <summary>
    /// Inicializacion
    /// </summary>
    void Start()
    {
        //Se obtiene el componente AudioSource de este GameObject y se guarda en la variable _audioSource
        _audioSource = GetComponent<AudioSource>();
    }

    /// <summary>
    /// Se usa para reproducir el sonido contenido en el AudioSource
    /// </summary>
    public void PlayAudio()
    {
        //Se usa el AudioSource y se usa su funcion Play
        _audioSource.Play();
    }

    /// <summary>
    /// Se usa para pausar el sonido contenido en el AudioSource
    /// </summary>
    public void PauseAudio()
    {
        //Se usa el AudioSource y se usa su funcion Play
        _audioSource.Pause();
    }

}
