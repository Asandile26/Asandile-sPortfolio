import {} from 'react';

interface ExampleCarouselImageProps {
  text: string; // Explicitly defining 'text' as a string
}

function ExampleCarouselImage({ text }: ExampleCarouselImageProps) {
  return (
    <div style={{ backgroundColor: '#eee', height: '400px', display: 'flex', justifyContent: 'center', alignItems: 'center' }}>
      <h2>{text}</h2>
    </div>
  );
}

export default ExampleCarouselImage;
