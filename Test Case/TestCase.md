# CABSYSTEM – Test Case

**Student:** Nguyen Huu Tien – 23706591

## Test Cases

| TC ID | Module | Test Scenario | Input | Expected Result |
|------|--------|---------------|-------|-----------------|
| TC001 | Login | Login with valid account | Valid email & password | User enters dashboard |
| TC002 | Login | Login with wrong password | Valid email + wrong password | Error message appears |
| TC003 | Register | Register new customer | Valid information | Account created successfully |
| TC004 | Booking | Create a trip | Pickup & destination | Trip is created |
| TC005 | Booking | Empty pickup location | Destination only | Validation error |
| TC006 | Driver | Driver goes online | Status = Online | Driver becomes available |
| TC007 | Driver | Auto assign driver | New trip | System assigns nearest driver |
| TC008 | Trip | Start trip | Assigned trip | Status = In Progress |
| TC009 | Trip | Complete trip | Finished trip | Status = Completed |
| TC010 | Payment | Cash payment | Completed trip | Payment saved |
| TC011 | Payment | E-wallet payment | Completed trip | Payment successful |
| TC012 | Rating | Submit rating | 5 stars | Rating stored |
| TC013 | Vehicle | Add vehicle | Valid vehicle data | Vehicle added |
| TC014 | Report | View trip report | Date range | Report displayed |
| TC015 | Logout | Logout system | Click Logout | Return to Login page |

## Acceptance Criteria

- All required fields are validated.
- Only online drivers receive new trips.
- Payment is available only after trip completion.
- Only the customer can submit a rating.
- Unauthorized users cannot access protected APIs.
