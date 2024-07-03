unit Character;

interface

type
  TCharacter = class
    public
      procedure Intro;
  end;

implementation

uses
  SysUtils;

procedure TCharacter.Intro;
begin
  Writeln('Universal International представляет');
  Writeln('- Угадай, кого? *бесячий смех*');
end;

end.
