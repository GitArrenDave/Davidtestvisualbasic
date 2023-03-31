param(
$nutzername = " ",
$nutzernachname = " ",
$rechnername = " ",
$pcxnummer = " ",
$absender = " ",
$ccadresse = " "
)

Send-MailMessage -From "<$absender>" -To "<$nutzername.$nutzernachname@desy.de>", "<$ccadresse>" -Subject 'Update Problem' -Body "Guten Tag $nutzername $nutzernachname, 
`nIhr Pc $rechnername (mit pcx-Nummer $pcxnummer) hat ein Updateproblem.
 `nKoennten Sie bitte den Pc mit dem DESY-Netzwerk verbinden und die notwendigen Updates installieren? `nAm Besten lassen Sie den Pc danach noch einige Stunden oder ueber Nacht verbunden, damit der Status korrekt vom Report abgefragt werden kann. 
 `nVielen Dank und viele Gruesse `n(Diese Mail wurde automatisch erstellt, bei Problemen koennen Sie aber gerne darauf antworten.`n `n `n `nDear $nutzername $nutzernachname, 
 `nYour Pc $rechnername (with pcx number $pcxnummer) has an update problem.
 `nCould you please connect the Pc to the DESY network and install the necessary updates? `nIt would be best to leave the Pc connected for a few hours or overnight afterwards, so that the status can be correctly reported. 
 `nThank you and best regards `n(This mail was created automatically, but if you have any problems, please feel free to reply to it." -Priority High -DeliveryNotificationOption OnSuccess, OnFailure -SmtpServer 'smtp.desy.de'

Write-Host "Just sent a mail"

