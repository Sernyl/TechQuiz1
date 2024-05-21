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
  Writeln('Universal International представл€ет');
  Writeln('- ”гадай, кого? *бес€чий смех*');
end;

end.