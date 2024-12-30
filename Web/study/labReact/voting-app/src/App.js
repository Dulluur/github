import React, { useState } from 'react';

// Компонент голосования
const VotingCard = ({ image, number, initialVotes }) => {
  const [votes, setVotes] = useState(initialVotes);

  const handleVote = () => setVotes(votes + 1);

  const styles = {
    
    card: {
      border: '1px solid #ddd',
      borderRadius: '10px',
      padding: '10px',
      margin: '10px',
      textAlign: 'center',
      width: '200px',
      backgroundColor: '#f5f5f5',
    },
    img: {
      width: '100%',
      height: 'auto',
      borderRadius: '5px',
    },
    button: {
      backgroundColor: '#ffa500',
      color: '#fff',
      border: 'none',
      borderRadius: '5px',
      padding: '10px',
      cursor: 'pointer',
    },
  };

  return (
    <div style={styles.card}>
      <img src={image} alt={`Номер ${number}`} style={styles.img} />
      <h3>Номер {number}</h3>
      <p>Голоса: {votes}</p>
      <button style={styles.button} onClick={handleVote}>
        👍 Голосовать
      </button>
    </div>
  );
};

// Главный компонент
const App = () => {
  const candidates = [
    { image: '/images/shrek.jpg', number: 1, initialVotes: 0 },
    { image: '/images/pirate.jpg', number: 2, initialVotes: 0 },
    { image: '/images/maleficent.jpg', number: 3, initialVotes: 0 },
    { image: '/images/megamind.jpg', number: 4, initialVotes: 0 },
  ];

  const containerStyle = {
    display: 'flex',
    flexWrap: 'wrap',
    justifyContent: 'center',
    backgroundColor: '#b2d8d8',
    padding: '20px',
    borderRadius: '10px',
  };

  return (
    <div>
      <h1 style={{ textAlign: 'center' }}>Голосование</h1>
      <div style={containerStyle}>
        {candidates.map((candidate) => (
          <VotingCard
            key={candidate.number}
            image={candidate.image}
            number={candidate.number}
            initialVotes={candidate.initialVotes}
          />
        ))}
      </div>
    </div>
  );
};

export default App;