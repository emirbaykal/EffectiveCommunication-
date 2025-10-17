# EffectiveCommunication

This is a simple study I've outlined on how communication should occur between classes.

Implementing this process within the “Enemy” class as follows:

- player.PlayAnim();
* player.PlaySound();
+ player.DecreaseHealt();

is an incorrect approach. Minimizing communication calls between two classes is the most effective method.

