using UnityEngine;

[System.Serializable]
public class Sound
{
    public SoundType Name;
    public AudioClip Clip;
}

public enum SoundType
{
    EXPLOSION_1, EXPLOSION_2, EXPLOSION_3,
    DAMAGE_1, DAMAGE_2, DAMAGE_3,
    BUTTON_CLICK_1, BUTTON_CLICK_2, BUTTON_HOVER,
    WIN_1, WIN_2,
    LOSE_1, LOSE_2,
    LEVELUP_1, LEVELUP_2,
    POWERUP_1, POWERUP_2,
    ATTACK_1, ATTACK_2, ATTACK_3,
    JUMP_1, JUMP_2, JUMP_3,
    HIT_1, HIT_2, HIT_3,
    BULLET_1, BULLET_2, BULLET_3,
    DASH,
    DEFENSE,
    ERROR,
    NOTIFICATION,
    PICKUP,
    TRANSITION_1, TRANSITION_2, TRANSITION_3,
    MUSIC_MENU, MUSIC_VICTORY, MUSIC_DEFEAT, 
    MUSIC_BACKGROUND_1, MUSIC_BACKGROUND_2, MUSIC_BACKGROUND_3
}