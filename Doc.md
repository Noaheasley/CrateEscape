 # EnemyBehaviour script

    Name: _damage
         Description: damage that an Enemy does
         Type: private float

    Name: _movement
         Description: ref for the EnemyMovementBehaviour script
         Type: EnemyMovementBehaviour
         
    Name: Awake()
         Description: activates the enemy
         Type: private void

    Name: OnCollisionEnter
         Description: once the player collides with the enemy it'll activate this function
         Type: private void

# EnemyMovementBehaviour Script

    Name: _rigidbody
         Description: gets a ref for the enemy's rigidbody
         Type:Rigidbody

    Name: _target
         Description: target for the enemy
         Type: GameObject
         
    Name: _agent
         Description: ref for the enemy's NavMeshAgent
         Type: NavMeshAgent
         
    Name: Target
         Description: getter and setter for Enemy's target
         Type: GameObject

# GameManagerBehaviour Script

    Name: _gameOver
         Description: determines if the game is over
         Type: private static bool
         
    Name: _isPlayerDead
         Description: determines if the player has died
         Type: private static bool
         
    Name: OnGameOver
         Description: does a game event once the game is over
         Type: GameEvent
         
    Name: _playerHealth
         Description: ref for the player health
         Type: HealthBehaviour
         
    Name: _enemyHealth
         Description: ref for the enemy health
         Type: HealthBehaviour

# HazardBehaviour script

    Name: _damage
         Description: determines the hazard's damage
         Type: private float
         
    Name: _speed
         Description: speed in which the hazard can travel
         Type: private float
         
    Name: _time
         Description: time that the count down timers reset to
         Type: private float
         
    Name: _countDownOut
         Description: countdown timer for hazards coming out
         Type: private float
         
    Name: _countDownIn
         Description: countdown for the hazards coming in
         Type: private float
         
    Name: OncollisionEnter
         Description: activates once an actor collides with it
         Type: private void
         
# HealthBehaviour script

    Name: _health
         Description: health of the actor
         Type: private float
         
     Name: _destroyOnDeath
         Description: destroys the actor once they die
         Type: private bool
         
    Name: Health
         Description: getter and setter for _heath
         Type: public float
         
    Name: TakeDamge
         Description: subtracts health from the actor once TakeDamage is called
         Type: public void

# CameraFollowPlayerBehaviour

    Name: player
         Description: ref for the player
         Type: GameObject
         
    Name: offset
         Description: offset for the camera
         Type: Vector3
         
# PlayerMovementBehaviour

    Name: _moveSpeed
         Description: movement speed for the player
         Type: private float
         
    Name: _camera
         Description: ref for the camera to get the mouse position
         Type: Camera
         
    Name: _rigidbody
         Description: ref for the player rigidbody
         Type: Rigidbody
