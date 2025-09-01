using UnityEngine;
using UnityEngine.UI;

public class ConfigMenu : MonoBehaviour
{
    public Slider brilhoSlider;
    public Slider volumeSlider;
    public Slider velocidadeSlider;

    public GameObject player;
    public AudioSource audioSource;
    public Light sceneLight;

    private PlayerController pc;

    private void Awake()
    {
        // Fallbacks automáticos, se algo não foi arrastado
        if (audioSource == null) audioSource = FindObjectOfType<AudioSource>();
        if (sceneLight == null) sceneLight = FindObjectOfType<Light>();
        if (player == null) player = GameObject.FindWithTag("Player");

        if (player != null) player.TryGetComponent(out pc);
    }

    private void Start()
    {
        // Velocidade (só conecta se existir PlayerController)
        if (velocidadeSlider != null && pc != null)
        {
            velocidadeSlider.value = pc.moveSpeed;
            velocidadeSlider.onValueChanged.AddListener(v => pc.moveSpeed = v);
        }

        // Volume
        if (volumeSlider != null && audioSource != null)
        {
            volumeSlider.value = audioSource.volume;
            volumeSlider.onValueChanged.AddListener(v => audioSource.volume = v);
        }

        // Brilho
        if (brilhoSlider != null && sceneLight != null)
        {
            brilhoSlider.value = sceneLight.intensity;
            brilhoSlider.onValueChanged.AddListener(v => sceneLight.intensity = v);
        }
    }
}
